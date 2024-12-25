using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectPanel : MonoBehaviour
{
    // ����ʵ��
    private static SelectPanel _instance;

    // ��̬������ȡ����ʵ��
    public static SelectPanel Instance
    {
        get
        {
            if (_instance == null)
            {
                //Debug.LogError("SelectPanel instance is not set!");
            }
            return _instance;
        }
    }

    public string country = "NULL"; // ��ǰѡ�еĹ���
    public List<string> total_country;
    public Button AmericaButton;
    public Button SovietButton;
    public Button UnitedKingdomButton;
    public Button GermanyButton;
    public Button JapanButton;
    public Button ItalyButton;
    public Button RandomSelectButton;
    public Button ConfirmButton;
    public TMP_Text text;

    // Awake������Start֮ǰ���ã����ڳ�ʼ������
    void Awake()
    {
        // ȷ��ֻ��һ��ʵ������
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject); // ��ֹ�ڳ����л�ʱ����
        }
        else
        {
            // ����Ѿ�����ʵ���������ٵ�ǰʵ��
            Destroy(gameObject);
            return;
        }

        // ��ʼ�������б�
        total_country = new List<string>();
        total_country.Add("����");
        total_country.Add("����");
        total_country.Add("Ӣ��");
        total_country.Add("�¹�");
        total_country.Add("�ձ�");
        total_country.Add("�����");
    }

    // Start is called before the first frame update
    void Start()
    {
        // ������Է���������Ҫ��Start��ִ�еĳ�ʼ���߼�
    }

    // Update is called once per frame
    void Update()
    {
        // ������Է�����Ҫÿ֡���µ��߼�
    }

    public void onclick_AmericaButton()
    {
        country = "����";
        text.text = "��ǰѡ��Ĺ��ң�" + country;
    }

    public void onclick_SovietButton()
    {
        country = "����";
        text.text = "��ǰѡ��Ĺ��ң�" + country;
    }

    public void onclick_UnitedKingdomButton()
    {
        country = "Ӣ��";
        text.text = "��ǰѡ��Ĺ��ң�" + country;
    }

    public void onclick_GermanyButton()
    {
        country = "�¹�";
        text.text = "��ǰѡ��Ĺ��ң�" + country;
    }

    public void onclick_JapanButton()
    {
        country = "�ձ�";
        text.text = "��ǰѡ��Ĺ��ң�" + country;
    }

    public void onclick_ItalyButton()
    {
        country = "�����";
        text.text = "��ǰѡ��Ĺ��ң�" + country;
    }

    public void onclick_RandomSelectButton()
    {
        System.Random random = new System.Random();
        int index = random.Next(0, total_country.Count);
        country = total_country[index];
        text.text = "��ǰѡ��Ĺ��ң�" + country;
    }

    public void onclick_ConfirmButton()
    {
        if (country != "NULL")
        {
            SceneManager.LoadScene("main");
        }
        else
        {
            Debug.Log("Please select a country first");
        }
    }
}
