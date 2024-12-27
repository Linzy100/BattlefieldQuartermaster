using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6304 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6304;
        cardName = "雷达";
        introduce = "每回合限一次，当处于补给状态的美国海军被攻击时:可弃置牌堆顶的2张牌，被攻击的海军不会被移除。";
        type = "状态卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6304";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
