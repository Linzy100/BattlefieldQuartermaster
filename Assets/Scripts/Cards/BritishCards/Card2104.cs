using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2104 : Card
{
    // Start is called before the first frame update
    public Card2104()
    {
        id = 2104;
        cardName = "发起海战";
        introduce = "";
        type = "基础卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2104";
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
