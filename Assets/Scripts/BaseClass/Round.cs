using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TurnStage
{
    PrePlayStage = 0,//����ǰ�׶�
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
    ThrowCardStage = 11//���ƽ׶�
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
public class Round
{
    public int turn;//20�غ�
    public TurnStage turnStage;
    public CountryStage countryStage;
}
