using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1504 : Card
{
    // Start is called before the first frame update
    public Card1504()
    {
        id = 1504;
        cardName = "潜艇：袭击摩尔曼斯克运输船队";
        introduce = "每有一支位于<斯堪的纳维亚>或与之相邻的德国陆军或海军，获得1分。苏联须弃置其牌堆顶的2张牌。";
        type = "经济战";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/100/1504";
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
