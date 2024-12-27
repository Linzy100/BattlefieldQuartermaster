using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2203 : Card
{
    // Start is called before the first frame update
    public Card2203()
    {
        id = 2203;
        cardName = "佩塔尔二世在南斯拉夫继位";
        introduce = "在<巴尔干>消灭一支轴心国陆军，在<巴尔干>征召英国陆军";
        type = "事件卡";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/200/2203";
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
