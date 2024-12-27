using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card5502 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 5502;
        cardName = "皇家海军封锁海路";
        introduce = "每有一支在版图上的意大利海军，获得1分。英国须弃置其牌堆顶的1张牌。";
        type = "经济战";
        country = "Italian";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/500/5502";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
