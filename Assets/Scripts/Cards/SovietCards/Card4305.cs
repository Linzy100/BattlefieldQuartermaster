using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4305 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 4305;
        cardName = "喀秋莎";
        introduce = "每回合限一次，你发起陆战后:可弃置1张手牌，在相同的地区发起陆战。";
        type = "状态卡";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/400/4305";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
