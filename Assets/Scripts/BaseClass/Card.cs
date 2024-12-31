using System;
using UnityEngine;

[Serializable]
public class Card
{
    public int id; // 卡牌编号
    public string cardName; // 卡牌名字
    public string introduce; // 卡牌技能介绍
    public string type; // 卡牌类型
    public string country; // 所属国家
    public bool towords; // 朝上朝下
    public string imagePath; // 图片路径
    public bool takeActionOfPlay; // 是否在开始回合执行
    public bool takeActionOfFly; // 是否在开始飞行执行
    public bool takeActionOfSupply; // 是否在补给回合执行
    public bool takeActionOfScore; // 是否在计分回合执行
    public bool takeActionOfGetCard; // 是否在摸牌回合执行
    public bool takeActionOfThrowCard; // 是否在弃牌回合执行
    public bool isNeedToSearch = true;//是否需要寻找目标
    public bool isFinishingSearch = false;//是否完成寻找目标
    public string affectingTarget = "none";//是否作用在自己身上
    public string affectingTargetType = "none";//作用对象类型（军队，地块）


    // 设置军队信息
    public void SetMilitaryInfo()
    {
    }

    // 设置选择的地块信息
    public void SetSelectedPlate()
    {
    }

    // 设置卡牌信息
    public void SetCardName()
    {
    }

    public virtual void func()
    {

    }
}
