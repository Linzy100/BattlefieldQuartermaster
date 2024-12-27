using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card5102 :  Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 5102;
        cardName = "发起陆战";
        introduce = "";
        type = "基础卡";
        country = "Italian";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/500/5102";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void func()
    {

    }
}
