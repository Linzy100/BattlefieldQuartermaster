using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card6206 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6206;
        cardName = "摩尔曼斯克运输船队";
        introduce = "在<罗斯地区>征召一支苏联陆军;苏联可组建一支陆军";
        type = "事件卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6206";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
