using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4401 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 4401;
        cardName = "保卫祖国";
        introduce = "在你的回合开始时触发:在<莫斯科>或其相邻地区征召陆军;在<莫斯科>消灭一支轴心国陆军。";
        type = "对策卡";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/400/4401";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
