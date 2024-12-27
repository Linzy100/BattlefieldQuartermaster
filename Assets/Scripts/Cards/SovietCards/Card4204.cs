using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4204 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 4204;
        cardName = "铁托游击队";
        introduce = "在<巴尔干>消灭一支轴心国陆军;在<巴尔干>征召一支苏联或英国陆军。";
        type = "事件卡";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/400/4204";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
