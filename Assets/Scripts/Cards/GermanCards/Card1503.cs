using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1503 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1503;
        cardName = "潜艇：袭击无防备运输船";
        introduce = "英国须弃置其牌堆顶的2张牌，若在<北海>没有同盟国海军则为3张。德国获得1分。";
        type = "经济战";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/100/1503";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
