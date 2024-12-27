using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card6303 : Card
{
    // Start is called before the first frame update
    public Card6303()
    {
        id = 6302;
        cardName = "空中堡垒";
        introduce = "当你打出【经济战卡】时：目标需弃置的牌需加二";
        type = "状态卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6303";
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
