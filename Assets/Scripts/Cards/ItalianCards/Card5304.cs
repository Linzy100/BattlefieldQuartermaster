using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card5304 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 5304;
        cardName = "意大利殖民地帝国";
        introduce = "在你的计分阶段:<非洲北部><非洲南部><中东>其中每有一个地区被轴心国占领，获得1分。";
        type = "状态卡";
        country = "Italian";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = true;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/500/5304";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
