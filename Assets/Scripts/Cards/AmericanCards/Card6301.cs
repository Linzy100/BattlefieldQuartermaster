using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6301 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6301;
        cardName = "航空母舰";
        introduce = "每回合限一次，当你发起海战时：可弃置牌堆顶的一张牌，在战斗区域建设海军";
        type = "状态卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6301";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
