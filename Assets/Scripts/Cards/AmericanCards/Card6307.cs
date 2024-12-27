using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card6307 : Card
{
    // Start is called before the first frame update
    public Card6307()
    {
        id = 6307;
        cardName = "战时生产";
        introduce = "每回合限一次，当你组建陆军时：可弃置牌堆顶的一张牌，再额外建设一支陆军";
        type = "状态卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6307";
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
