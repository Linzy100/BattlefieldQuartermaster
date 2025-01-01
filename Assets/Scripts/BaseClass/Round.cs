using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TurnStage
{
    /*PrePlayStage = 0,//����ǰ�׶�
    PlayStage = 1,//���ƽ׶�
    PreFlyStage = 2,//����ǰ�׶�
    FlyStage = 3,//���н׶�
    PreSupplyStage = 4,//����ǰ�׶�
    SupplyStage = 5,//�����׶�
    PreScoreStage = 6,//�Ʒ�ǰ�׶�
    ScoreStage = 7,//�Ʒֽ׶�
    PreGetCardStage = 8,//����ǰ�׶�
    GetCardStage = 9,//���ƽ׶�
    PreThrowCardStage = 10,//����ǰ�׶�
    ThrowCardStage = 11//���ƽ׶�*/
    PlayStage = 0,//���ƽ׶�
    //FlyStage,//���н׶�
    //SupplyStage = 1,//�����׶�
    ScoreStage = 1,//�Ʒֽ׶�
    ThrowCardStage = 2,//���ƽ׶�
    GetCardStage = 3//���ƽ׶�
}
public enum CountryStage//����˳��
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
    public int turn;//20�غ�
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

    // ����SupplyStageʱ���õķ���
    public void OnSupplyStage()
    {
        // �������������Ҫ�����ķ����߼�
        //Debug.Log("SupplyStage triggered");
        //���ò����׶εķ���(����countryStage�ַ���)

    }

    public void OnScoreStage()
    {
        // ��ȡ��ǰ���ҵ�����
        string currentCountry = countryStage.ToString();

        // ��ȡ��ǰ����ռ�е����еؿ�
        List<plateData> occupiedPlates = PlateManager.Instance.getPlateInfoByCountry(currentCountry);

        // ɸѡ���÷ֵ������������
        int score = 0;
        foreach (var plate in occupiedPlates)
        {
            if (plate.isAlliesScore || plate.isAxisScore)
            {
                score=score+2;
            }
        }
        //�жϵ�ǰ���������ĸ���Ӫ
        if (currentCountry == "Germany" || currentCountry == "Japan" || currentCountry == "Italy")
        {
            //�¹����ձ���������������Ĺ�
            //�������ӵ����Ĺ��ķ�����
            ScoreManager.Instance.AddAxisScore(score);
        }
        else
        {
            ScoreManager.Instance.AddAlliesScore(score);
        }

        RoundManager.Instance.Statetransition();
            // �����ǰ���ҵĵ÷�
            //Debug.Log($"{currentCountry} �÷�: {score}");
    }

    public void OnGetCardStage()
    {
        CardManager.Instance.GetHandCardtoSeven(RoundManager.Instance.returnCurCountryName());
        PlayPanel.Instance.SetUIHandCards();

        RoundManager.Instance.Statetransition();
    }
}
