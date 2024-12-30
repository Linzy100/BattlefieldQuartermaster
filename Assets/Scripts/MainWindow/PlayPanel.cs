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
        // 初始化面板
        country_image.sprite = Resources.Load<Sprite>("Art/" + country);
        SetUIRoundText();
        SetUIScoreAndArmyNavy(country);
        SetUIHandCards();
    }

    public void SetUIScoreAndArmyNavy(string country)
    {
        Score_Allies.text = "同盟国得分：" + ScoreManager.Instance.Score_Allies;
        Score_Axis.text = "轴心国得分：" + ScoreManager.Instance.Score_Axis;

        // 根据country参数动态获取相应国家的实例
        switch (country)
        {
            case "America":
                RemainingArmy.text = "剩余陆军：" + America.Instance.army;
                RemainingNavy.text = "剩余海军：" + America.Instance.navy;
                break;
            case "Soviet":
                RemainingArmy.text = "剩余陆军：" + Soviet.Instance.army;
                RemainingNavy.text = "剩余海军：" + Soviet.Instance.navy;
                break;
            case "UnitedKingdom":
                RemainingArmy.text = "剩余陆军：" + UnitedKingdom.Instance.army;
                RemainingNavy.text = "剩余海军：" + UnitedKingdom.Instance.navy;
                break;
            case "Germany":
                RemainingArmy.text = "剩余陆军：" + Germany.Instance.army;
                RemainingNavy.text = "剩余海军：" + Germany.Instance.navy;
                break;
            case "Japan":
                RemainingArmy.text = "剩余陆军：" + Japan.Instance.army;
                RemainingNavy.text = "剩余海军：" + Japan.Instance.navy;
                break;
            case "Italy":
                RemainingArmy.text = "剩余陆军：" + Italy.Instance.army;
                RemainingNavy.text = "剩余海军：" + Italy.Instance.navy;
                break;
            default:
                Debug.LogError("Unknown country: " + country);
                // 设置默认值或处理未知国家的情况
                RemainingArmy.text = "剩余陆军：未知";
                RemainingNavy.text = "剩余海军：未知";
                break;
        }
    }

    public void SetUIRoundText()
    {
        //RoundManager.Instance.turn;
        current_round = "当前回合：" + RoundManager.Instance.round.turn.ToString();
        round_text.text = current_round;
        round_country_text.text = "当前回合国家：" + TranslateENtoCH(RoundManager.Instance.round.countryStage.ToString())+ "\n" + "回合阶段：\n" + RoundManager.Instance.round.turnStage.ToString();
    }

    public void GetCardsToSeven()
    {
        //if()
    }

    public void SetUIHandCards()
    {
        ClearPreviousCards();
        //根据country来显示当前国家持有手牌
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

    // 清理之前创建的卡牌
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
            Debug.Log("出牌：" + CardClickHandler.selectedCard.gameObject.name);
            switch(country)
            {
                case "America":
                    {
                        for (int i = America.Instance.HandCards.Count - 1; i >= 0; i--)
                        {
                            Card card = America.Instance.HandCards[i];
                             if (card.cardName == CardClickHandler.selectedCard.gameObject.name)
                            {//打出的卡牌有的进入弃牌堆有的不进入（比如状态卡）
                                if (card.type == "状态卡")
                                {//remove函数有问题
                                    America.Instance.HandCards.RemoveAt(i);
                                    America.Instance.StatusCards.Add(card);
                                }
                                else if(card.type == "对策卡")
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
                                if (card.type == "状态卡")
                                {
                                    Soviet.Instance.HandCards.RemoveAt(i);
                                    Soviet.Instance.StatusCards.Add(card);
                                }
                                else if (card.type == "对策卡")
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
                            if (card.type == "状态卡")
                            {
                                UnitedKingdom.Instance.HandCards.RemoveAt(i);
                                UnitedKingdom.Instance.StatusCards.Add(card);
                            }
                            else if (card.type == "对策卡")
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
                            if (card.type == "状态卡")
                            {
                                Germany.Instance.HandCards.RemoveAt(i);
                                Germany.Instance.StatusCards.Add(card);
                            }
                            else if (card.type == "对策卡")
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
                            if (card.type == "状态卡")
                            {
                                Japan.Instance.HandCards.RemoveAt(i);
                                Japan.Instance.StatusCards.Add(card);
                            }
                            else if (card.type == "对策卡")
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
                            if (card.type == "状态卡")
                            {
                                Italy.Instance.HandCards.RemoveAt(i);
                                Italy.Instance.StatusCards.Add(card);
                            }
                            else if (card.type == "对策卡")
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
            Debug.Log("未选中牌");
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

    public string TranslateENtoCH(string text)
    {
        switch (text)
        {
            case "America":
                return "美国";
                break;
            case "Soviet":
                return "苏联";
                break;
            case "UnitedKingdom":
                return "英国";
                break;
            case "Germany":
                return "德国";
                break;
            case "Japan":
                return "日本";
                break;
            case "Italy":
                return "意大利";
                break;
        }
        return null;
    }


}
