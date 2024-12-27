using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.LookDev;
using UnityEngine.UI;

public class StatusCardPanel : MonoBehaviour
{
    public GameObject cardPrefab;
    public string country;
    public List<string> other_country;
    public GameObject country1;
    public GameObject country2;
    public GameObject country3;
    public GameObject country4;
    public GameObject country5;
    public List<GameObject> countries;
    public int count = 0;


    void Start()
    {
        country=SelectPanel.Instance.country;
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

        IntializeStatusCardPanel();
    }

    void OnEnable()
    {
        // 每次启用StatusCardPanel时调用
        UpdateStatusCardPanel();
    }
    public void IntializeStatusCardPanel()
    {  
        country1.GetComponent<TMP_Text>().text = other_country[0];
        country2.GetComponent<TMP_Text>().text = other_country[1];
        country3.GetComponent<TMP_Text>().text = other_country[2];
        country4.GetComponent<TMP_Text>().text = other_country[3];
        country5.GetComponent<TMP_Text>().text = other_country[4];
    }

    public void UpdateStatusCardPanel()
    {
        // 清理之前实例化的卡牌
        if (count != 0)//第一次不需要清理
        {
            foreach (GameObject countryObj in countries)
            {
                foreach (Transform child in countryObj.transform)
                {
                    if (child.gameObject != countryObj)
                    {
                        Destroy(child.gameObject);
                    }
                }
            }
        }

        for (int i = 0; i < other_country.Count; i++)
        {
            string str = other_country[i];
            string str2 = Translate(str);
            float x = countries[i].transform.position.x + 200;
            float y = countries[i].transform.position.y - 50;
            float z = countries[i].transform.position.z;
            if (str2 == America.Instance.country)
            {
                for (int j = 0; j < America.Instance.StatusCards.Count; j++)
                {
                    Card card = America.Instance.StatusCards[j];
                    string imagePath = card.imagePath;
                    GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, countries[i].transform);
                    card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                    x = x + 200;
                }
            }
            else if (str2 == Soviet.Instance.country)
            {
                for (int j = 0; j < Soviet.Instance.StatusCards.Count; j++)
                {
                    Card card = Soviet.Instance.StatusCards[j];
                    string imagePath = card.imagePath;
                    GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, countries[i].transform);
                    card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                    x = x + 200;
                }
            }
            else if (str2 == UnitedKingdom.Instance.country)
            {
                for (int j = 0; j < UnitedKingdom.Instance.StatusCards.Count; j++)
                {
                    Card card = UnitedKingdom.Instance.StatusCards[j];
                    string imagePath = card.imagePath;
                    GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, countries[i].transform);
                    card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                    x = x + 200;
                }
            }
            else if (str2 == Germany.Instance.country)
            {
                for (int j = 0; j < Germany.Instance.StatusCards.Count; j++)
                {
                    Card card = Germany.Instance.StatusCards[j];
                    string imagePath = card.imagePath;
                    GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, countries[i].transform);
                    card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                    x = x + 200;
                }
            }
            else if (str2 == Japan.Instance.country)
            {
                for (int j = 0; j < Japan.Instance.StatusCards.Count; j++)
                {
                    Card card = Japan.Instance.StatusCards[j];
                    string imagePath = card.imagePath;
                    GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, countries[i].transform);
                    card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                    x = x + 200;
                }
            }
            else if (str2 == Italy.Instance.country)
            {
                for (int j = 0; j < Italy.Instance.StatusCards.Count; j++)
                {
                    Card card = Italy.Instance.StatusCards[j];
                    string imagePath = card.imagePath;
                    GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, countries[i].transform);
                    card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                    x = x + 200;
                }
            }
            else
            {
                Debug.Log("Error");
            }
        }
        //Debug.Log("test");
        count++;
    }
    public string Translate(string text)
    {
        switch(text)
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
        this.GetComponentInParent<Canvas>().transform.Find("AmericanPlayPanel").gameObject.SetActive(true);
    }
}
