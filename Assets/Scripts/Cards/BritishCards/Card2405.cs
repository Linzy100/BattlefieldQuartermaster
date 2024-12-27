using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2405 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2405;
        cardName = "驱逐舰";
        introduce = "当处于补给状态的美国或英国海军将被移除时触发:本回合此海军不会被移除";
        type = "对策卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2405";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
