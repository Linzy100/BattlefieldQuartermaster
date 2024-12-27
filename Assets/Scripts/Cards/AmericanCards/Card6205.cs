using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card6205 : Card
{
    // Start is called before the first frame update
    public Card6205()
    {
        id = 6205;
        cardName = "武器援助";
        introduce = "选择英国或者苏联，其可打出一张手牌，摸一张牌";
        type = "事件卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6205";
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
