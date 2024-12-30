using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TurnStage
{
    PrePlayStage = 0,//³öÅÆÇ°½×¶Î
    PlayStage = 1,//³öÅÆ½×¶Î
    PreFlyStage = 2,//·ÉÐÐÇ°½×¶Î
    FlyStage = 3,//·ÉÐÐ½×¶Î
    PreSupplyStage = 4,//²¹¸øÇ°½×¶Î
    SupplyStage = 5,//²¹¸ø½×¶Î
    PreScoreStage = 6,//¼Æ·ÖÇ°½×¶Î
    ScoreStage = 7,//¼Æ·Ö½×¶Î
    PreGetCardStage = 8,//ÃþÅÆÇ°½×¶Î
    GetCardStage = 9,//ÃþÅÆ½×¶Î
    PreThrowCardStage = 10,//ÆúÅÆÇ°½×¶Î
    ThrowCardStage = 11//ÆúÅÆ½×¶Î
}
public enum CountryStage//³öÅÆË³Ðò
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
    public int turn;//20»ØºÏ
    public TurnStage turnStage;
    public CountryStage countryStage;
}
