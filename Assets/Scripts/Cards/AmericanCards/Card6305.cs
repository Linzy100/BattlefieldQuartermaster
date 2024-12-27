using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6305 : Card
{
    // Start is called before the first frame update
    public Card6305()
    {
        id = 6305;
        cardName = "柳钉女工";
        introduce = "每回合限一次，在你的弃牌阶段开始时：可将1置2张手牌置于牌堆底";
        type = "状态卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = true;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6305";
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
