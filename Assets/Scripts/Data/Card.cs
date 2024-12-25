using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Card
{
    public String name;
    public String introduce;//卡牌技能介绍
    public String type;//卡牌类型
    public String country;//所属国家
    public bool toword;//朝上朝下
    public bool takeactionOfPlay;//是否在开始回合执行
    public bool takeactionOfFly;//是否在开始飞行执行
    public bool takeactionOfSupply;//是否在补给回合执行
    public bool takeactionOfScore;//是否在计分回合执行
    public bool takeactionOfGetCard;//是否在摸牌回合执行
    public bool takeactionOfThrowCard;//是否在弃牌牌回合执行

}
