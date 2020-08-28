using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    // 新規セーブデータ作成
    public void OnSaveNewPlayer()
    {
        // セーブデータ作成
        SavePlayerData player = CreateSavePlayerData();

        // バイナリ形式でシリアル化
        BinaryFormatter bf = new BinaryFormatter();

        // 指定したパスにファイルを作成
        FileStream file = File.Create(SaveFilePath);

        // Closeが確実に呼ばれるように例外処理を用いる
        try
        {
            // 指定したオブジェクトを上で作成したストリームにシリアル化する
            bf.Serialize(file, player);
        }
        finally
        {
            if (file != null)
                file.Close();
        }
    }

    // 
    private SavePlayerData CreateSavePlayerData()
    {
        SavePlayerData player = new SavePlayerData();
        player.Event_Flag = 0;
        player.Room_Flag = 0;
        player.x = 0.0;
        player.y = 0.0;
        player.Archivement = 0;

        return player;
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