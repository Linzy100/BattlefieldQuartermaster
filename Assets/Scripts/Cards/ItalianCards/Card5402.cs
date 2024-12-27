using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card5402 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 5402;
        cardName = "卡西诺山";
        introduce = "当位于<意大利>的轴心国陆军将被移除时触发:本回合该陆军不会被移除。";
        type = "对策卡";
        country = "Italian";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/500/5402";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
