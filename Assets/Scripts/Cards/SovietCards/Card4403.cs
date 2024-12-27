using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4403 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 4403;
        cardName = "莫斯科保卫战";
        introduce = "当<莫斯科>的苏联陆军将被移除时触发:本回合这支陆军不会被移除。";
        type = "对策卡";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/400/4403";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
