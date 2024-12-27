using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2304 : Card
{
    // Start is called before the first frame update
    public Card2304()
    {
        id = 2304;
        cardName = "反法西斯抵抗运动";
        introduce = "在你的出牌阶段:可[放弃打出手牌并弃置2张手牌，在<西欧>或<意大利>发起陆战。";
        type = "状态卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2304";
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
