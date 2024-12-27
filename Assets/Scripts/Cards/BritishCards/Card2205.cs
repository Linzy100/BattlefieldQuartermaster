using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2205 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2205;
        cardName = "波兰地下党";
        introduce = "消灭位于<东欧>的一支轴心国陆军";
        type = "事件卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2205";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
