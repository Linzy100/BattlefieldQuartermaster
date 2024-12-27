using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2401 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2401;
        cardName = "反潜战术";
        introduce = "当轴心国打出【经济战卡】时触发:此【经济战卡】效果无效。";
        type = "对策卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2401";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
