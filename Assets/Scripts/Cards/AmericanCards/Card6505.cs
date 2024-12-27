using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6505 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6505;
        cardName = "SBD 无畏式俯冲轰炸机";
        introduce = "若距离<日本>两个地区以内存在美国海军，日本须弃置牌堆顶的4张牌";
        type = "经济战";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6505";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
