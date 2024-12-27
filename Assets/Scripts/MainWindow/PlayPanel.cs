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
        // ��ʼ�����
        country_image.sprite = Resources.Load<Sprite>("Art/" + country);

        current_round = "��ǰ�غϣ�" + round.ToString();
        round_text.text = current_round;
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

    public void GetCardsToSeven()
    {
        //if()
    }

    public void SetUIHandCards()
    {
        //����country����ʾ��ǰ��������
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
}
