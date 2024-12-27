using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4306 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 4306;
        cardName = "女性义务兵役";
        introduce = "在你的出牌阶段打出【建设陆军】时:可将此【建设陆军】置入手牌而非弃牌堆。";
        type = "状态卡";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//是否在开始飞行执行
        takeActionOfSupply = false;//是否在补给回合执行
        takeActionOfScore = false;//是否在计分回合执行
        takeActionOfGetCard = false;//是否在摸牌回合执行
        takeActionOfThrowCard = false;//是否在弃牌牌回合执行
        imagePath = "Art/Cards/400/4306";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
