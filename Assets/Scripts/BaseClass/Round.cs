using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TurnStage
{
    PrePlayStage,//����ǰ�׶�
    PlayStage,//���ƽ׶�
    PreFlyStage,//����ǰ�׶�
    FlyStage,//���н׶�
    PreSupplyStage,//����ǰ�׶�
    SupplyStage,//�����׶�
    PreScoreStage,//�Ʒ�ǰ�׶�
    ScoreStage,//�Ʒֽ׶�
    PreGetCardStage,//����ǰ�׶�
    GetCardStage,//���ƽ׶�
    PreThrowCardStage,//����ǰ�׶�
    ThrowCardStage//���ƽ׶�
}
public enum CountryStage//����˳��
{
    Germany,
    UnitedKingdom,
    Japan,
    Soviet,
    Italy,
    American
}
public class Round
{
    public int turn;//20�غ�
    public TurnStage turnStage;
    public CountryStage countryStage;
}
