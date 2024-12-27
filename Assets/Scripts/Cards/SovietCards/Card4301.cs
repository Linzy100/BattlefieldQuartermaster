using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4301 : Card
{
    // Start is called before the first frame update
    public Card4301()
    {
        id = 4301;
        cardName = "正面攻击";
        introduce = "每回合限一次，当你发起陆战后:可弃置2张手牌，在战斗地区或其相邻地区发起陆战。";
        type = "状态卡";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/400/4301";
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
