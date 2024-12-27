using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2303 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2303;
        cardName = "麦肯齐·金起草国家资源动员法";
        introduce = "在你的计分阶段:若在<北大西洋>有英国海军，获得1分;若在<加拿大ン有英国陆军，获得1分。";
        type = "状态卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = true;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2303";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
