using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Round
{
    public enum Stage
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
    public enum WhichContryIsPlaying//����˳��
    {
        Germany,
        UnitedKingdom,
        Japan,
        Soviet,
        Italy,
        American
    }
    public int turn;//20�غ�
    public Stage stage;
    public WhichContryIsPlaying contry;
}
