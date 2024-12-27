using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1305 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1305;
        cardName = "丰富的资源";
        introduce = "在你的计分阶段:每有一支位于<乌克兰><哈萨克斯坦><罗斯地区>的德国陆军，获得1分";
        type = "状态卡";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = true;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/100/1305";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
