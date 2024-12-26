using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;

public class AmericanPlayPanel : MonoBehaviour
{
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
        country = "America";
        IntializeAmericanPanel();
    }

    // Update is called once per frame
    void Update()
    {
        Score_Allies.text = "ͬ�˹��÷֣�" + ScoreManager.Instance.Score_Allies;
        Score_Axis.text = "���Ĺ��÷֣�" + ScoreManager.Instance.Score_Axis;
        RemainingArmy.text = "ʣ��½����" + America.Instance.army;
        RemainingNavy.text = "ʣ�ຣ����" + America.Instance.navy;
    }

    void IntializeAmericanPanel()
    {
        // ��ʼ���������
        country_image.sprite = Resources.Load<Sprite>("Art/America");
        current_round = "��ǰ�غϣ�" + round.ToString();
        round_text.text = current_round;
        Score_Allies.text = "ͬ�˹��÷֣�" + ScoreManager.Instance.Score_Allies;
        Score_Axis.text = "���Ĺ��÷֣�" + ScoreManager.Instance.Score_Axis;
        RemainingArmy.text = "ʣ��½����" + America.Instance.army;
        RemainingNavy.text = "ʣ�ຣ����" + America.Instance.navy;
    }
}
