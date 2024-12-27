using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card3411 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 3411;
        cardName = "丘克群岛";
        introduce = "当处于补给状态的意大利陆军被移除后触发:在该地区征召德国陆军。";
        type = "对策卡";
        country = "Japan";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = true;//是否在开始飞行执行
        takeActionOfSupply = true;//是否在补给回合执行
        takeActionOfScore = true;//是否在计分回合执行
        takeActionOfGetCard = true;//是否在摸牌回合执行
        takeActionOfThrowCard = true;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/300/3411";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
