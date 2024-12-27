using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card5403 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 5403;
        cardName = "罗马尼亚增援";
        introduce = "当处于补给状态的德国陆军被移除后触发:在该地区征召意大利陆军。";
        type = "对策卡";
        country = "Italian";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/500/5403";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
