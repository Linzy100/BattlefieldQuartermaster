using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2502 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2502;
        cardName = "马耳他潜艇群";
        introduce = "德国和意大利各自弃置牌堆顶2张牌，或移除其位于<地中海>的海军";
        type = "经济战";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2502";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
