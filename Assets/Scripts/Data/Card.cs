using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Card :MonoBehaviour 
{
    public int id;//卡牌编号
    public String cardName;//卡牌名字
    public String introduce;//卡牌技能介绍
    public String type;//卡牌类型
    public String country;//所属国家
    public bool towords;//朝上朝下
    public bool takeActionOfPlay;//是否在开始回合执行
    public bool takeActionOfFly;//是否在开始飞行执行
    public bool takeActionOfSupply;//是否在补给回合执行
    public bool takeActionOfScore;//是否在计分回合执行
    public bool takeActionOfGetCard;//是否在摸牌回合执行
    public bool takeActionOfThrowCard;//是否在弃牌牌回合执行

}
