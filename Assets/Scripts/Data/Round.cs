using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TurnStage
{
    PrePlayStage,//³öÅÆÇ°½×¶Î
    PlayStage,//³öÅÆ½×¶Î
    PreFlyStage,//·ÉÐÐÇ°½×¶Î
    FlyStage,//·ÉÐÐ½×¶Î
    PreSupplyStage,//²¹¸øÇ°½×¶Î
    SupplyStage,//²¹¸ø½×¶Î
    PreScoreStage,//¼Æ·ÖÇ°½×¶Î
    ScoreStage,//¼Æ·Ö½×¶Î
    PreGetCardStage,//ÃþÅÆÇ°½×¶Î
    GetCardStage,//ÃþÅÆ½×¶Î
    PreThrowCardStage,//ÆúÅÆÇ°½×¶Î
    ThrowCardStage//ÆúÅÆ½×¶Î
}
public enum CountryStage//³öÅÆË³Ðò
{
    Germany,
    UnitedKingdom,
    Japan,
    Soviet,
    Italy,
    American
}
class Round: MonoBehaviour
{
    public int turn;//20»ØºÏ
    public TurnStage turnStage;
    public CountryStage countryStage;
}
