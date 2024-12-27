using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card6503 : Card
{
    // Start is called before the first frame update
    public Card6503()
    {
        id = 6503;
        cardName = "B-29 超级堡垒";
        introduce = "若距离<日耳曼>三个地区以内存在美国陆军，德国须弃置牌堆顶的5张牌。";
        type = "经济战";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/600/6503";
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
