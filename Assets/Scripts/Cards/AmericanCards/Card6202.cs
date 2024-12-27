using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card6202 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6202;
        cardName = "珍珠港部署舰队";
        introduce = "在<夏威夷>征召陆军;在<夏威夷>的相邻海域征召海军";
        type = "事件卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6202";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }

}
