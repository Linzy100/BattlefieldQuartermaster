using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card4102 :  Card
{
    // Start is called before the first frame update
    public Card4102()
    {
        id = 4102;
        cardName = "发起陆战";
        introduce = "";
        type = "基础卡";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/400/4102";
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
