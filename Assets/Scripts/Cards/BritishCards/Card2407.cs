using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2407 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2407;
        cardName = "皇家空军";
        introduce = "当位于<不列颠群岛>或与之相邻的英国部队将被移除时触发:本回合此部队不会被移除。";
        type = "对策卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2407";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
