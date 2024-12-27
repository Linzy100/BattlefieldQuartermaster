using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6204 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6204;
        cardName = "瓜达卡纳尔岛";
        introduce = "在<新西兰>征召陆军;在<新西兰>相邻海域征召海军";
        type = "事件卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6204";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
