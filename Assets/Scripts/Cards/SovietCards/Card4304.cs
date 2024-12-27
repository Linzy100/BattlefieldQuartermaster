using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4304 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 4304;
        cardName = "什维尔尼克疏散委员会";
        introduce = "苏联陆军总是处于补给状态。(陆军依然只能建设在大本营或邻接其他苏联部队的地区)";
        type = "状态卡";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/400/4304";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
