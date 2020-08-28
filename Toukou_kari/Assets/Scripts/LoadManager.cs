using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formaters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    private void LoadPlayer()
    {
        if (File.Exits(SaveFilePath))
        {
            // バイナリ形式でデシリアライズ
            BinaryFormatter bf = new BinaryFormatter();

            // 指定したパスのファイルストリームを開く
            FileStream file = File.Open(SaveFilePath, FileMode.Open);

            try
            {
                // 指定したファイルストリームをオブジェクトにデシリアライズ
                SavePlayerData player = (SavePlayerData)bf.Deserialize(file);

                // 読み込んだデータを反映
                var playerObject = Instantiate(playerPrefab) as GameObject;
                playerObject.GetComponent<PlayerController>().Init(player.Item, player.Room, player.x, player.y, player.Archivement);
            }
            finally
            {
                // ファイル操作には明示的な破棄が必要．Closeを忘れないように
                if (file != null)
                    file.Close();
            }
        }
        else
        {
            Debug.Log("no load file");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
