using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2406 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2406;
        cardName = "效忠吾王";
        introduce = "当轴心国在<印度>或<澳大利亚>或<加拿大>建设陆军时触发:立刻消灭此陆军。";
        type = "对策卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2406";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
