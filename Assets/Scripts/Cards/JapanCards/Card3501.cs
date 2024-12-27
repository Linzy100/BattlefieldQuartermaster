using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card3501 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 3501;
        cardName = "印度洋警备队";
        introduce = "每有一支位于<阿拉伯海>或与之相邻的日本海军，获得2分。英国须弃置其牌堆顶的 2张牌。";
        type = "经济战";
        country = "Japan";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/300/3501";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
