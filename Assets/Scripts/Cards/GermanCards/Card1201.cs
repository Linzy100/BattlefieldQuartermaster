using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1201 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1201;
        cardName = "枪支或黄油";
        introduce = "此卡牌可视为【建设陆军】【建设海军】【陆战】【海战】其中之一打出。";
        type = "事件卡";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/100/1201";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
