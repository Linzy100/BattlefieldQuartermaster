using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card6102 :  Card
{
    // Start is called before the first frame update
    public Card6102()
    {
        id = 6102;
        cardName = "发起陆战";
        introduce = "";
        type = "基础卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6102";
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
