using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CardFuncManager : Singleton<CardFuncManager>
{
    public Card curCard;
    public plateData curPlate;
    public string[] curdMilitary = new string[2];  // 用于存储军队信息
    public Button confirmButton; // 用于用户确认的按钮
    private bool isWaitingForUserInput = false; // 是否等待用户输入


    public bool Germany1101()
    {
        //先判断是否有选择地块
        //判断能否建设陆军
        GameObject tipPanel = this.GetComponentInParent<Canvas>().transform.Find("TipPanel").gameObject;
        if (PlateClickHandler.selectedPlate == null)
        {
            tipPanel.SetActive(true);
            TipPanel.Instance.SetLogText("未选择地块！");
            return false;
        }
        //Debug.Log(PlateClickHandler.selectedPlate.name);
        //return true;
        List<plateData> list=SearchOperation.Instance.SearchSetArmy(RoundManager.Instance.returnCurCountryName(), PlateManager.Instance.returnAllPlateInfo(), RoundManager.Instance.returnCurCampName());
        foreach(plateData plateData in list)
        {
            if(plateData.plateName.Equals(PlateClickHandler.selectedPlate.name))
            {
                //建设陆军修改属性
                CardManager.Instance.card1101.func("Germany", "Axis","Army",PlateClickHandler.selectedPlate.name);
                return true;
            }
        }
        tipPanel.SetActive(true);
        TipPanel.Instance.SetLogText("该地块不可建设陆军！");
        return false;
    }
        



    //public void playCard()  //获取卡牌
    //{
    //    curCard = UIManager.Instance.selectedCard;
    //    // 如果当前有卡牌
    //    if (curCard.cardName != null)
    //    {
    //        if (curCard.isNeedToSearch && curCard.isFinishingSearch == false)
    //        {
    //            // 执行搜寻操作
    //            PerformSearchOperation();
    //            isWaitingForUserInput = true; // 设置为等待用户输入
    //        }
    //        else if (curCard.isNeedToSearch && curCard.isFinishingSearch == true)
    //        {
    //            // 当不需要搜寻或者搜寻已完成时，执行卡牌的func操作
    //            curCard.func();
    //            curCard = null; // 执行完卡牌操作后，将卡牌置为null
    //            curCard.isFinishingSearch = false;
    //        }
    //    }
    //}

    //private void Update()
    //{
        
    //}

    //// 执行搜寻操作
    //private void PerformSearchOperation()
    //{
    //    List<plateData> p = new List<plateData>();
    //    //创建搜索列表
    //    if (curCard.cardName.Equals("建设陆军"))
    //    {
    //        p = SearchOperation.Instance.SearchSetArmy(RoundManager.Instance.returnCurCountryName(), PlateManager.Instance.returnAllPlateInfo(), RoundManager.Instance.returnCurCampName());
    //    }
    //    else if (curCard.cardName.Equals("建设海军"))
    //    {
    //        p = SearchOperation.Instance.SearchSetNavy(RoundManager.Instance.returnCurCountryName(), PlateManager.Instance.returnAllPlateInfo(), RoundManager.Instance.returnCurCampName());
    //    }
    //    else if (curCard.cardName.Equals("发起陆战"))
    //    {
    //    }
    //    else if (curCard.cardName.Equals("发起海战"))
    //    {

    //    }


    //    if (curCard.affectingTarget == "other")
    //    {
    //        if (curCard.affectingTargetType == "Military")
    //        {
    //            curdMilitary = GameManager.Instance.uIManager.selectedMilitary;
    //        }
    //        else if (curCard.affectingTargetType == "Plate")
    //        {
    //            curPlate = p.Contains(GameManager.Instance.uIManager.selectedPlate)
    //           ? GameManager.Instance.uIManager.selectedPlate
    //           : null;

    //        }
    //    }


    //}

    //// 用户点击确认按钮后，标记搜索完成
    //private void OnConfirmClick()
    //{
    //    curCard.isFinishingSearch = true;
    //}

}
