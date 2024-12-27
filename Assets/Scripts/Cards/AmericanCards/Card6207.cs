using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card6207 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6207;
        cardName = "代号:Magic";
        introduce = "从桌面弃置一张日本的响应牌(不公开牌的效果)";
        type = "事件卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6207";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func() { 
    
    }
}
