using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6302 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6302;
        cardName = "登录作战";
        introduce = "每回合限一次，当你发起陆战时:若战斗地区邻接处于补给状态的美国海军，你可弃置牌堆顶的1张牌，在该地区建设陆军。";
        type = "状态卡";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
