using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountermeasuresCardPanel : MonoBehaviour
{
    public string country;
    public List<string> other_country;
    public GameObject country1;
    public GameObject country2;
    public GameObject country3;
    public GameObject country4;
    public GameObject country5;
    public List<GameObject> countries;
    void Start()
    {
        country = SelectPanel.Instance.country;
        List<string> total_country = SelectPanel.Instance.total_country;
        other_country = new List<string>();
        //total_country中移除country就是other_country
        foreach (string c in total_country)
        {
            if (c != country)
            {
                other_country.Add(c);
            }
        }
        country1 = GameObject.Find("country1");
        country2 = GameObject.Find("country2");
        country3 = GameObject.Find("country3");
        country4 = GameObject.Find("country4");
        country5 = GameObject.Find("country5");
        countries = new List<GameObject>();
        countries.Add(country1);
        countries.Add(country2);
        countries.Add(country3);
        countries.Add(country4);
        countries.Add(country5);

        UpdateCountermeasuresCardPanel();
    }

    void OnEnable()
    {
        // 每次启用StatusCardPanel时调用
        UpdateCountermeasuresCardPanel();
    }


    public void UpdateCountermeasuresCardPanel()
    {
        for (int i = 0; i < other_country.Count; i++)
        {
            string str = other_country[i];
            string str2 = Translate(str);
            if (str2 == America.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "美国："+America.Instance.CountermeasuresCards.Count.ToString();
            else if (str2 == Soviet.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "苏联：" + Soviet.Instance.CountermeasuresCards.Count.ToString();
            else if (str2 == UnitedKingdom.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "英国：" + UnitedKingdom.Instance.CountermeasuresCards.Count.ToString();
            else if (str2 == Germany.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "德国：" + Germany.Instance.CountermeasuresCards.Count.ToString();
            else if (str2 == Japan.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "日本：" + Japan.Instance.CountermeasuresCards.Count.ToString();
            else if (str2 == Italy.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "意大利：" + Italy.Instance.CountermeasuresCards.Count.ToString();
        }
    }

    public string Translate(string text)
    {
        switch (text)
        {
            case "美国":
                return "America";
                break;
            case "苏联":
                return "Soviet";
                break;
            case "英国":
                return "UnitedKingdom";
                break;
            case "德国":
                return "Germany";
                break;
            case "日本":
                return "Japan";
                break;
            case "意大利":
                return "Italy";
                break;
        }
        return null;
    }

    public void onclick_BackButton()
    {
        gameObject.SetActive(false);
        this.GetComponentInParent<Canvas>().transform.Find("PlayPanel").gameObject.SetActive(true);
    }
}
