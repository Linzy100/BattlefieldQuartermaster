using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6502 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6502;
        cardName = "B-26 掠夺者";
        introduce = "若距离某轴心国的大本营三个地区以内存在美国陆军，该轴心国须弃置牌堆顶的4张牌。";
        type = "经济战";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6501";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
