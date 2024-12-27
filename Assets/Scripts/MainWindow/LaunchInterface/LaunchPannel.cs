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
        // �ڱ༭���У�Application.Quit()���������˳���Ϸ��
        // �������ǿ������һ��������־��ȷ�ϴ������˳�����
        Debug.Log("Game has been instructed to quit.");
    }

    public void onclick_settingButton()
    {

    }   
}
