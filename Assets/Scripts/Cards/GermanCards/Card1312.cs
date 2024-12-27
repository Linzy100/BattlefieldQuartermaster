using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1312 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1312;
        cardName = "群狼战术";
        introduce = "任何玩家打出带有【潜艇】字样的【经济战卡】时:可令目标须弃置的卡牌数加2，若<斯堪的纳维亚>有德国陆军则为 3张。";
        type = "状态卡";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/100/1312";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
