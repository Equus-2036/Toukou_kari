using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TITLE : MonoBehaviour
{
    // Start をクリックでGameScene に遷移
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("GameScene_0");
    }

    // Exit をクリックで終了
    public void OnClickExitButton()
    {
        Application.Quit();
    }
}