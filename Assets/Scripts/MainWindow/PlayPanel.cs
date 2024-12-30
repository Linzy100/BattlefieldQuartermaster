using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayPanel : MonoBehaviour
{
    public GameObject cardPrefab;

    public string country;
    public Image country_image;

    public TMP_Text round_text;
    public TMP_Text round_country_text;
    public string current_round;

    //
    public TMP_Text Score_Allies;
    public TMP_Text Score_Axis;
    public TMP_Text RemainingArmy;
    public TMP_Text RemainingNavy;

    public Transform cardParent;
    // Start is called before the first frame update
    void Start()
    {
        country = SelectPanel.Instance.country;//
        country = TranslateCHtoEN(country);
        InitializePanel(country);
    }

    // Update is called once per frame
    void Update()
    {
        SetUIRoundText();
        SetUIScoreAndArmyNavy(country);
    }

    public void InitializePanel(string country)
    {
        // ��ʼ�����
        country_image.sprite = Resources.Load<Sprite>("Art/" + country);
        SetUIRoundText();
        SetUIScoreAndArmyNavy(country);
        SetUIHandCards();
    }

    public void SetUIScoreAndArmyNavy(string country)
    {
        Score_Allies.text = "ͬ�˹��÷֣�" + ScoreManager.Instance.Score_Allies;
        Score_Axis.text = "���Ĺ��÷֣�" + ScoreManager.Instance.Score_Axis;

        // ����country������̬��ȡ��Ӧ���ҵ�ʵ��
        switch (country)
        {
            case "America":
                RemainingArmy.text = "ʣ��½����" + America.Instance.army;
                RemainingNavy.text = "ʣ�ຣ����" + America.Instance.navy;
                break;
            case "Soviet":
                RemainingArmy.text = "ʣ��½����" + Soviet.Instance.army;
                RemainingNavy.text = "ʣ�ຣ����" + Soviet.Instance.navy;
                break;
            case "UnitedKingdom":
                RemainingArmy.text = "ʣ��½����" + UnitedKingdom.Instance.army;
                RemainingNavy.text = "ʣ�ຣ����" + UnitedKingdom.Instance.navy;
                break;
            case "Germany":
                RemainingArmy.text = "ʣ��½����" + Germany.Instance.army;
                RemainingNavy.text = "ʣ�ຣ����" + Germany.Instance.navy;
                break;
            case "Japan":
                RemainingArmy.text = "ʣ��½����" + Japan.Instance.army;
                RemainingNavy.text = "ʣ�ຣ����" + Japan.Instance.navy;
                break;
            case "Italy":
                RemainingArmy.text = "ʣ��½����" + Italy.Instance.army;
                RemainingNavy.text = "ʣ�ຣ����" + Italy.Instance.navy;
                break;
            default:
                Debug.LogError("Unknown country: " + country);
                // ����Ĭ��ֵ����δ֪���ҵ����
                RemainingArmy.text = "ʣ��½����δ֪";
                RemainingNavy.text = "ʣ�ຣ����δ֪";
                break;
        }
    }

    public void SetUIRoundText()
    {
        //RoundManager.Instance.turn;
        current_round = "��ǰ�غϣ�" + RoundManager.Instance.round.turn.ToString();
        round_text.text = current_round;
        round_country_text.text = "��ǰ�غϹ��ң�" + TranslateENtoCH(RoundManager.Instance.round.countryStage.ToString())+ "\n" + "�غϽ׶Σ�\n" + RoundManager.Instance.round.turnStage.ToString();
    }

    public void GetCardsToSeven()
    {
        //if()
    }

    public void SetUIHandCards()
    {
        ClearPreviousCards();
        //����country����ʾ��ǰ���ҳ�������
        float x = this.transform.Find("HandCardArea").transform.position.x - 335;
        float y = this.transform.Find("HandCardArea").transform.position.y;
        float z = this.transform.Find("HandCardArea").transform.position.z;
        switch (country)
        {
            case "America":
                {
                    foreach (Card card in America.Instance.HandCards)
                    {
                        GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, this.transform.Find("cardParent").transform);
                        card1.name = card.cardName;
                        card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(card.imagePath);
                        x += 112;
                    }
                }
                break;
            case "Soviet":
                {
                    foreach (Card card in Soviet.Instance.HandCards)
                    {
                        GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, this.transform.Find("cardParent").transform);
                        card1.name = card.cardName;
                        card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(card.imagePath);
                        x += 112;
                    }
                }
                break;
            case "UnitedKingdom":
                {
                    foreach (Card card in UnitedKingdom.Instance.HandCards)
                    {
                        GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, this.transform.Find("cardParent").transform);
                        card1.name = card.cardName;
                        card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(card.imagePath);
                        x += 112;
                    }
                }
                break;
            case "Germany":
                {
                    foreach (Card card in Germany.Instance.HandCards)
                    {
                        GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, this.transform.Find("cardParent").transform);
                        card1.name = card.cardName;
                        card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(card.imagePath);
                        x += 112;
                    }
                }
                break;
            case "Japan":
                {
                    foreach (Card card in Japan.Instance.HandCards)
                    {
                        GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, this.transform.Find("cardParent").transform);
                        card1.name = card.cardName;
                        card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(card.imagePath);
                        x += 112;
                    }
                }
                break;
            case "Italy":
                {
                    foreach (Card card in Italy.Instance.HandCards)
                    {
                        GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, this.transform.Find("cardParent").transform);
                        card1.name = card.cardName;
                        card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(card.imagePath);
                        x += 112;
                    }
                }
                break;
            default:
                Debug.LogError("Unknown country: " + country);
                break;
        }
    }

    // ����֮ǰ�����Ŀ���
    private void ClearPreviousCards()
    {
        if (cardParent != null)
        {
            foreach (Transform child in cardParent)
            {
                Destroy(child.gameObject);
            }
        }
        else
        {
            Debug.LogError("Card parent Transform is not assigned!");
        }
    }

    public void OnClickDiscardButton()
    {
        if (CardClickHandler.selectedCard != null)
        {
            Debug.Log("���ƣ�" + CardClickHandler.selectedCard.gameObject.name);
            switch(country)
            {
                case "America":
                    {
                        for (int i = America.Instance.HandCards.Count - 1; i >= 0; i--)
                        {
                            Card card = America.Instance.HandCards[i];
                             if (card.cardName == CardClickHandler.selectedCard.gameObject.name)
                            {//����Ŀ����еĽ������ƶ��еĲ����루����״̬����
                                if (card.type == "״̬��")
                                {//remove����������
                                    America.Instance.HandCards.RemoveAt(i);
                                    America.Instance.StatusCards.Add(card);
                                }
                                else if(card.type == "�Բ߿�")
                                {
                                    America.Instance.HandCards.RemoveAt(i);
                                    America.Instance.CountermeasuresCards.Add(card);
                                }
                                else
                                {
                                    America.Instance.HandCards.RemoveAt(i);
                                    America.Instance.DiscardPile.Add(card);
                                }
                                break;
                            }
                        }
                    }
                    break;
                case "Soviet":
                    {
                        for (int i = Soviet.Instance.HandCards.Count - 1; i >= 0; i--)
                        {
                            Card card = Soviet.Instance.HandCards[i];
                            if (card.cardName == CardClickHandler.selectedCard.gameObject.name)
                            {
                                if (card.type == "״̬��")
                                {
                                    Soviet.Instance.HandCards.RemoveAt(i);
                                    Soviet.Instance.StatusCards.Add(card);
                                }
                                else if (card.type == "�Բ߿�")
                                {
                                    Soviet.Instance.HandCards.RemoveAt(i);
                                    Soviet.Instance.CountermeasuresCards.Add(card);
                                }
                                else
                                {
                                    Soviet.Instance.HandCards.RemoveAt(i);
                                    Soviet.Instance.DiscardPile.Add(card);
                                }
                                break;
                            }
                        }
                    }
                    break;
                case "UnitedKingdom":
                    {
                        for (int i = UnitedKingdom.Instance.HandCards.Count - 1; i >= 0; i--)
                        {
                            Card card = UnitedKingdom.Instance.HandCards[i];
                            if (card.type == "״̬��")
                            {
                                UnitedKingdom.Instance.HandCards.RemoveAt(i);
                                UnitedKingdom.Instance.StatusCards.Add(card);
                            }
                            else if (card.type == "�Բ߿�")
                            {
                                UnitedKingdom.Instance.HandCards.RemoveAt(i);
                                UnitedKingdom.Instance.CountermeasuresCards.Add(card);
                            }
                            else
                            {
                                UnitedKingdom.Instance.HandCards.RemoveAt(i);
                                UnitedKingdom.Instance.DiscardPile.Add(card);
                            }
                            break;
                        }
                    }
                    break;
                case "Germany":
                    {
                        for (int i = Germany.Instance.HandCards.Count - 1; i >= 0; i--)
                        {
                            Card card = Germany.Instance.HandCards[i];
                            if (card.type == "״̬��")
                            {
                                Germany.Instance.HandCards.RemoveAt(i);
                                Germany.Instance.StatusCards.Add(card);
                            }
                            else if (card.type == "�Բ߿�")
                            {
                                Germany.Instance.HandCards.RemoveAt(i);
                                Germany.Instance.CountermeasuresCards.Add(card);
                            }
                            else
                            {
                                Germany.Instance.HandCards.RemoveAt(i);
                                Germany.Instance.DiscardPile.Add(card);
                            }
                            break;
                        }
                    }
                    break;
                case "Japan":
                    {
                        for (int i = Japan.Instance.HandCards.Count - 1; i >= 0; i--)
                        {
                            Card card = Japan.Instance.HandCards[i];
                            if (card.type == "״̬��")
                            {
                                Japan.Instance.HandCards.RemoveAt(i);
                                Japan.Instance.StatusCards.Add(card);
                            }
                            else if (card.type == "�Բ߿�")
                            {
                                Japan.Instance.HandCards.RemoveAt(i);
                                Japan.Instance.CountermeasuresCards.Add(card);
                            }
                            else
                            {
                                Japan.Instance.HandCards.RemoveAt(i);
                                Japan.Instance.DiscardPile.Add(card);
                            }
                            break;
                        }
                    }
                    break;
                case "Italy":
                    {
                        for (int i = Italy.Instance.HandCards.Count - 1; i >= 0; i--)
                        {
                            Card card = Italy.Instance.HandCards[i];
                            if (card.type == "״̬��")
                            {
                                Italy.Instance.HandCards.RemoveAt(i);
                                Italy.Instance.StatusCards.Add(card);
                            }
                            else if (card.type == "�Բ߿�")
                            {
                                Italy.Instance.HandCards.RemoveAt(i);
                                Italy.Instance.CountermeasuresCards.Add(card);
                            }
                            else
                            {
                                Italy.Instance.HandCards.RemoveAt(i);
                                Italy.Instance.DiscardPile.Add(card);
                            }
                            break;
                        }
                    }
                    break;
            }
            SetUIHandCards();
        }
        else
        {
            Debug.Log("δѡ����");
        }
    }

    public void OnClickViewStatusCountermeasuresCardButton()
    {
        this.GetComponentInParent<Canvas>().transform.Find("StatusCardAndCountermeasuresCardPanel").gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
    public void OnClickViewOtherStatusCardButton()
    {
        GameObject panel = this.GetComponentInParent<Canvas>().transform.Find("StatusCardPanel").gameObject;
        panel.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void OnClickViewOtherCountermeasuresCardButton()
    {
        GameObject panel = this.GetComponentInParent<Canvas>().transform.Find("CountermeasuresCardPanel").gameObject;
        panel.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public string TranslateCHtoEN(string text)
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

    public string TranslateENtoCH(string text)
    {
        switch (text)
        {
            case "America":
                return "����";
                break;
            case "Soviet":
                return "����";
                break;
            case "UnitedKingdom":
                return "Ӣ��";
                break;
            case "Germany":
                return "�¹�";
                break;
            case "Japan":
                return "�ձ�";
                break;
            case "Italy":
                return "�����";
                break;
        }
        return null;
    }


}
