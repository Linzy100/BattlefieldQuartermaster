using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card5202 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 5202;
        cardName = "西班牙蓝色师";
        introduce = "从桌面弃置1张苏联的【响应卡】。不公开此卡的内容)";
        type = "事件卡";
        country = "Italian";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/500/5202";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
