using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2302 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2302;
        cardName = "维克托·霍普宣布印度参战";
        introduce = "当你建设陆军时:可在<印度>征召陆军来代替建设陆军。";
        type = "状态卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2302";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
