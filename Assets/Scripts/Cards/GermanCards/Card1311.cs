using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1311 : Card
{
    // Start is called before the first frame update
    public Card1311()
    {
        id = 1311;
        cardName = "人民冲锋队";
        introduce = "每回合限一次，在你的回合开始时:可弃置牌堆顶的1张牌，在<日耳曼>征召陆军。(不计入出牌阶段的行动)";
        type = "状态卡";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/100/1311";
    }
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
