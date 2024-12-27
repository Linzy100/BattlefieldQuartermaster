using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2402 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2402;
        cardName = "破译恩尼格玛密码";
        introduce = "当德国发动【状态卡】效果后触发:(在结算该效果后)弃置此【状态卡】。";
        type = "对策卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2402";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
