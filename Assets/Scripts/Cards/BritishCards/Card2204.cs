using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2204 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2204;
        cardName = "新加坡要塞化";
        introduce = "在<东南亚>征召陆军，在<南海>征召海军";
        type = "事件卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2204";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
