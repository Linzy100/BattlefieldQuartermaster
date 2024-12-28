using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusCardAndCountermeasuresCardPanel : MonoBehaviour
{
    // Start is called before the first frame update
    public string country;
    public TMP_Text text1;
    public TMP_Text text2;

    public GameObject cardPrefab4;
    void Start()
    {
        country = Translate(SelectPanel.Instance.country);
        text1 = GameObject.Find("Text1").GetComponent<TMP_Text>();
        text2 = GameObject.Find("Text2").GetComponent<TMP_Text>();
        Debug.Log(text1.gameObject.name);
        Debug.Log(text2.gameObject.name);

        UpdateStatusCards();
        UpdateCountermeasuresCard();
    }

    // Update is called once per frame
    private void OnEnable()
    {
        //UpdateStatusCards();
        //UpdateCountermeasuresCard();
    }


    public void OnClickBackButton()
    {
        this.GetComponentInParent<Canvas>().transform.Find("PlayPanel").gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void OnClickUseButton()
    {
        if (CardClickHandler.selectedCard != null)
        {
            Debug.Log("发动选中牌：" + CardClickHandler.selectedCard.gameObject.name);
        }
        else
        {
            Debug.Log("未选中牌");
        }
    }


    public void UpdateStatusCards()
    {
        float x=text1.transform.position.x;
        float y = text1.transform.position.y-200;
        float z = text1.transform.position.z;

        if(country==America.Instance.country)
        {
            foreach (Card card in America.Instance.StatusCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation,this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text1.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x +=250;
            }
        }
        else if(country == Soviet.Instance.country)
        {
            foreach (Card card in Soviet.Instance.StatusCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation, this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text1.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x += 250;
            }
        }
        else if (country == UnitedKingdom.Instance.country)
        {
            foreach (Card card in UnitedKingdom.Instance.StatusCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation, this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text1.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x += 250;
            }
        }
        else if (country == Germany.Instance.country)
        {
            foreach (Card card in Germany.Instance.StatusCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation, this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text1.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x += 250;
            }
        }
        else if (country == Japan.Instance.country)
        {
            foreach (Card card in Japan.Instance.StatusCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation, this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text1.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x += 250;
            }
        }
        else if (country == Italy.Instance.country)
        {
            foreach (Card card in Italy.Instance.StatusCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation, this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text1.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x += 250;
            }
        }
        else
        {
            Debug.Log("Error");
        }
    }

    public void UpdateCountermeasuresCard()
    {
        float x = text2.transform.position.x;
        float y = text2.transform.position.y - 200;
        float z = text2.transform.position.z;

        if (country == America.Instance.country)
        {
            foreach (Card card in America.Instance.CountermeasuresCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation, this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text2.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x += 250;
            }
        }
        else if (country == Soviet.Instance.country)
        {
            foreach (Card card in Soviet.Instance.CountermeasuresCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation, this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text2.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x += 250;
            }
        }
        else if (country == UnitedKingdom.Instance.country)
        {
            foreach (Card card in UnitedKingdom.Instance.CountermeasuresCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation, this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text2.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x += 250;
            }
        }
        else if (country == Germany.Instance.country)
        {
            foreach (Card card in Germany.Instance.CountermeasuresCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation, this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text2.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x += 250;
            }
        }
        else if (country == Japan.Instance.country)
        {
            foreach (Card card in Japan.Instance.CountermeasuresCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation, this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text2.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x += 250;
            }
        }
        else if (country == Italy.Instance.country)
        {
            foreach (Card card in Italy.Instance.CountermeasuresCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab4, new Vector3(x, y, z), this.transform.rotation, this.transform);
                string imagePath = card.imagePath;
                cardInstance.transform.SetParent(text2.transform);
                cardInstance.GetComponent<Image>().sprite = Resources.Load<Sprite>(imagePath);
                cardInstance.gameObject.name = card.cardName;
                x += 250;
            }
        }
        else
        {
            Debug.Log("Error");
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
}
