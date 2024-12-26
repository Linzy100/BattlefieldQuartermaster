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
        Score_Allies.text = "同盟国得分：" + ScoreManager.Instance.Score_Allies;
        Score_Axis.text = "轴心国得分：" + ScoreManager.Instance.Score_Axis;
        RemainingArmy.text = "剩余陆军：" + America.Instance.army;
        RemainingNavy.text = "剩余海军：" + America.Instance.navy;
    }

    void IntializeAmericanPanel()
    {
        // 初始化美国面板
        country_image.sprite = Resources.Load<Sprite>("Art/America");
        current_round = "当前回合：" + round.ToString();
        round_text.text = current_round;
        Score_Allies.text = "同盟国得分：" + ScoreManager.Instance.Score_Allies;
        Score_Axis.text = "轴心国得分：" + ScoreManager.Instance.Score_Axis;
        RemainingArmy.text = "剩余陆军：" + America.Instance.army;
        RemainingNavy.text = "剩余海军：" + America.Instance.navy;
    }
}
