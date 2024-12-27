using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2305 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2305;
        cardName = "英国皇家海军";
        introduce = "每回合限一次，当你发起海战时:可弃置2张手牌，在发起海战的海域或另一个海域发起海战";
        type = "状态卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2305";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
