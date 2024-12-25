using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectPanel : MonoBehaviour
{
    // 单例实例
    private static SelectPanel _instance;

    // 静态方法获取单例实例
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

    public string country = "NULL"; // 当前选中的国家
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

    // Awake方法在Start之前调用，用于初始化单例
    void Awake()
    {
        // 确保只有一个实例存在
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject); // 防止在场景切换时销毁
        }
        else
        {
            // 如果已经存在实例，则销毁当前实例
            Destroy(gameObject);
            return;
        }

        // 初始化国家列表
        total_country = new List<string>();
        total_country.Add("美国");
        total_country.Add("苏联");
        total_country.Add("英国");
        total_country.Add("德国");
        total_country.Add("日本");
        total_country.Add("意大利");
    }

    // Start is called before the first frame update
    void Start()
    {
        // 这里可以放置其他需要在Start中执行的初始化逻辑
    }

    // Update is called once per frame
    void Update()
    {
        // 这里可以放置需要每帧更新的逻辑
    }

    public void onclick_AmericaButton()
    {
        country = "美国";
        text.text = "当前选择的国家：" + country;
    }

    public void onclick_SovietButton()
    {
        country = "苏联";
        text.text = "当前选择的国家：" + country;
    }

    public void onclick_UnitedKingdomButton()
    {
        country = "英国";
        text.text = "当前选择的国家：" + country;
    }

    public void onclick_GermanyButton()
    {
        country = "德国";
        text.text = "当前选择的国家：" + country;
    }

    public void onclick_JapanButton()
    {
        country = "日本";
        text.text = "当前选择的国家：" + country;
    }

    public void onclick_ItalyButton()
    {
        country = "意大利";
        text.text = "当前选择的国家：" + country;
    }

    public void onclick_RandomSelectButton()
    {
        System.Random random = new System.Random();
        int index = random.Next(0, total_country.Count);
        country = total_country[index];
        text.text = "当前选择的国家：" + country;
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
