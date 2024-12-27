using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1505 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1505;
        cardName = "V2：飞弹";
        introduce = "若有德国陆军位于<西欧>，获得3分。英国须弃置其牌堆顶的1张牌。";
        type = "经济战";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/100/1505";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
