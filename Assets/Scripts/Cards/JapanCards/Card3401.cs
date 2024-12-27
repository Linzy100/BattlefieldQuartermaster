using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card3401 : Card
{
    // Start is called before the first frame update
    public Card3401()
    {
        id = 3401;
        cardName = "万岁冲锋";
        introduce = "当你发起陆战后触发:在战斗地区或相邻地区发起陆战。";
        type = "对策卡";
        country = "Japan";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/300/3401";
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
