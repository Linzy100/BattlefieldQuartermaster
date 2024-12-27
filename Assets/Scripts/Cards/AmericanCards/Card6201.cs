using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card6201 : Card
{
    // Start is called before the first frame update
    public Card6201()
    {
        id = 6201;
        cardName = "民主兵工厂";
        introduce = "英军可按顺序建设一支陆军和一支海军";
        type = "事件卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6201";

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
