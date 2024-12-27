using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1307 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1307;
        cardName = "喷气式战斗机";
        introduce = "当你成为【经济战卡】的目标时:须弃置的卡牌数减3，最低为0。";
        type = "状态卡";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/100/1307";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
