using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card3303 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 3303;
        cardName = "帝国之野望";
        introduce = "在你的计分阶段:若<硫磺岛>或<菲律宾>有日本陆军，获得1分。";
        type = "状态卡";
        country = "Japan";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = true;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/300/3303";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
