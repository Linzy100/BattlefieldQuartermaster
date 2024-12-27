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
        //total_country���Ƴ�country����other_country
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
        // ÿ������StatusCardPanelʱ����
        UpdateCountermeasuresCardPanel();
    }


    public void UpdateCountermeasuresCardPanel()
    {
        for (int i = 0; i < other_country.Count; i++)
        {
            string str = other_country[i];
            string str2 = Translate(str);
            if (str2 == America.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "������"+America.Instance.CountermeasuresCards.Count.ToString();
            else if (str2 == Soviet.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "������" + Soviet.Instance.CountermeasuresCards.Count.ToString();
            else if (str2 == UnitedKingdom.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "Ӣ����" + UnitedKingdom.Instance.CountermeasuresCards.Count.ToString();
            else if (str2 == Germany.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "�¹���" + Germany.Instance.CountermeasuresCards.Count.ToString();
            else if (str2 == Japan.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "�ձ���" + Japan.Instance.CountermeasuresCards.Count.ToString();
            else if (str2 == Italy.Instance.country)
                countries[i].GetComponent<TMP_Text>().text = "�������" + Italy.Instance.CountermeasuresCards.Count.ToString();
        }
    }

    public string Translate(string text)
    {
        switch (text)
        {
            case "����":
                return "America";
                break;
            case "����":
                return "Soviet";
                break;
            case "Ӣ��":
                return "UnitedKingdom";
                break;
            case "�¹�":
                return "Germany";
                break;
            case "�ձ�":
                return "Japan";
                break;
            case "�����":
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
