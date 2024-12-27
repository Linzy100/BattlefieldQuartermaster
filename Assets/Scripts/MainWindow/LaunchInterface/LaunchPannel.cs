using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LaunchPannel : MonoBehaviour
{
    // Start is called before the first frame update
    public Button startButton;
    public Button exitButton;
    public Button settingButton;
    
    public void onclick_startButton()
    {
        //SceneManager.LoadScene("CountrySelect");
        this.GetComponentInParent<Canvas>().transform.Find("SelectPanel").gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void onclick_exitButton()
    {
        Application.Quit();
        // 在编辑器中，Application.Quit()不会真正退出游戏，
        // 所以我们可以添加一个调试日志来确认触发了退出操作
        Debug.Log("Game has been instructed to quit.");
    }

    public void onclick_settingButton()
    {

    }   
}
