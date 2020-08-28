using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    // MENU をクリックで MENU Panel を提示
    public void OnClickMENUButton()
    {
        SceneManager.LoadScene("MENU_Scene");
    }

    // Game Button をクリックで GameScene へ遷移
    public void onClickGameButton()
    {
        SceneManager.LoadScene("GameScene_0");
    }

    /*
     * 未実装
    // Option Button をクリックで OptionScene へ遷移
    public void onClickOptionButton()
    {
        SceneManager.LoadScene("OptionScene");
    }
    */

    // TITLE Button をクリックで TITLEScene へ遷移
    public void onClickTITLEButton()
    {
        SceneManager.LoadScene("Start_Game");
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
