using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;

public class PlayPanel : MonoBehaviour
{
    public GameObject cardPrefab;

    public string country;
    public Image country_image;

    public TMP_Text round_text;
    public string current_round;
    public int round = 1;

    //
    public TMP_Text Score_Allies;
    public TMP_Text Score_Axis;
    public TMP_Text RemainingArmy;
    public TMP_Text RemainingNavy;
    // Start is called before the first frame update
    void Start()
    {
        country = SelectPanel.Instance.country;//
        country=Translate(country);
        InitializePanel(country);
    }

    // Update is called once per frame
    void Update()
    {
        SetUIScoreAndArmyNavy(country);
    }

    public void InitializePanel(string country)
    {
        // 初始化面板
        country_image.sprite = Resources.Load<Sprite>("Art/" + country);

        current_round = "当前回合：" + round.ToString();
        round_text.text = current_round;
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

    public void GetCardsToSeven()
    {
        //if()
    }

    public void SetUIHandCards()
    {
        //根据country来显示当前国家手牌
        float x = this.transform.Find("HandCardArea").transform.position.x-325;
        float y = this.transform.Find("HandCardArea").transform.position.y;
        float z = this.transform.Find("HandCardArea").transform.position.z;
        switch (country)
        {
            case "America":
                {
                    foreach(Card card in America.Instance.HandCards)
                    {
                        GameObject card1 = Instantiate(cardPrefab, new Vector3(x, y, z), this.transform.rotation, this.transform);
                        card1.name = card.cardName;
                        card1.GetComponent<Image>().sprite = Resources.Load<Sprite>(card.imagePath);
                        x += 112;
                    }
                }
                break;
            case "Soviet":

                break;
            case "UnitedKingdom":

                break;
            case "Germany":

                break;
            case "Japan":

                break;
            case "Italy":

                break;
            default:
                Debug.LogError("Unknown country: " + country);
                break;
        }
    }


    public void OnClickViewStatusCardButton()
    {
        GameObject panel= this.GetComponentInParent<Canvas>().transform.Find("StatusCardPanel").gameObject;
        panel.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void OnClickViewCountermeasuresCardButton()
    {
        GameObject panel = this.GetComponentInParent<Canvas>().transform.Find("CountermeasuresCardPanel").gameObject;
        panel.SetActive(true);
        this.gameObject.SetActive(false);
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
