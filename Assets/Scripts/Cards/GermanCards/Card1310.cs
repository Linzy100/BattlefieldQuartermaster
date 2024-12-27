using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1310 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2310;
        cardName = "合成燃料";
        introduce = "每回合限一次，当你建设陆军后:可弃置牌堆顶的2张牌，在建设陆军的相邻地区建设一支陆军。";
        type = "状态卡";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/100/1310";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
