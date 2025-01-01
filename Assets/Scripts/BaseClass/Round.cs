using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TurnStage
{
    /*PrePlayStage = 0,//出牌前阶段
    PlayStage = 1,//出牌阶段
    PreFlyStage = 2,//飞行前阶段
    FlyStage = 3,//飞行阶段
    PreSupplyStage = 4,//补给前阶段
    SupplyStage = 5,//补给阶段
    PreScoreStage = 6,//计分前阶段
    ScoreStage = 7,//计分阶段
    PreGetCardStage = 8,//摸牌前阶段
    GetCardStage = 9,//摸牌阶段
    PreThrowCardStage = 10,//弃牌前阶段
    ThrowCardStage = 11//弃牌阶段*/
    PlayStage = 0,//出牌阶段
    //FlyStage,//飞行阶段
    //SupplyStage = 1,//补给阶段
    ScoreStage = 1,//计分阶段
    ThrowCardStage = 2,//弃牌阶段
    GetCardStage = 3//摸牌阶段
}
public enum CountryStage//出牌顺序
{
    Germany = 0,
    UnitedKingdom = 1,
    Japan = 2,
    Soviet = 3,
    Italy = 4,
    American = 5
}
/*public class Round
{
    public int turn;//20回合
    public TurnStage turnStage;
    public CountryStage countryStage;
}*/

public class Round
{
    private TurnStage _turnStage;
    public TurnStage turnStage
    {
        get { return _turnStage; }
        set
        {
            _turnStage = value;
            /*if (_turnStage == TurnStage.SupplyStage)
            {
                OnSupplyStage();
            }*/
            if(_turnStage == TurnStage.ScoreStage)
            {
                OnScoreStage();
            }
            if (_turnStage == TurnStage.GetCardStage)
            {
                OnGetCardStage();
            }
        }
    }

    public int turn { get; set; }
    public CountryStage countryStage { get; set; }

    // 触发SupplyStage时调用的方法
    public void OnSupplyStage()
    {
        // 在这里添加你想要触发的方法逻辑
        //Debug.Log("SupplyStage triggered");
        //调用补给阶段的方法(传入countryStage字符串)

    }

    public void OnScoreStage()
    {
        // 获取当前国家的名字
        string currentCountry = countryStage.ToString();

        // 获取当前国家占有的所有地块
        List<plateData> occupiedPlates = PlateManager.Instance.getPlateInfoByCountry(currentCountry);

        // 筛选出得分地区并计算分数
        int score = 0;
        foreach (var plate in occupiedPlates)
        {
            if (plate.isAlliesScore || plate.isAxisScore)
            {
                score=score+2;
            }
        }
        //判断当前国家属于哪个阵营
        if (currentCountry == "Germany" || currentCountry == "Japan" || currentCountry == "Italy")
        {
            //德国、日本、意大利属于轴心国
            //将分数加到轴心国的分数上
            ScoreManager.Instance.AddAxisScore(score);
        }
        else
        {
            ScoreManager.Instance.AddAlliesScore(score);
        }

        RoundManager.Instance.Statetransition();
            // 输出当前国家的得分
            //Debug.Log($"{currentCountry} 得分: {score}");
    }

    public void OnGetCardStage()
    {
        CardManager.Instance.GetHandCardtoSeven(RoundManager.Instance.returnCurCountryName());
        PlayPanel.Instance.SetUIHandCards();

        RoundManager.Instance.Statetransition();
    }
}
