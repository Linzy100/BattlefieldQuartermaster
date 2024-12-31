using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFuncManager : MonoBehaviour
{
    public Card curCard;
    public plateData curPlate;
    public string[] curdMilitary = new string[2];  // 用于存储军队信息
    public Button confirmButton; // 用于用户确认的按钮
    private bool isWaitingForUserInput = false; // 是否等待用户输入


    public void playCard()  //获取卡牌
    {
        curCard = GameManager.Instance.uIManager.selectedCard;
    }

    private void Update()
    {
        // 如果当前有卡牌
        if (curCard != null)
        {
            if (curCard.isNeedToSearch && curCard.isFinishingSearch == false )
            {
                // 执行搜寻操作
                PerformSearchOperation();
                isWaitingForUserInput = true; // 设置为等待用户输入
            }
            else if (curCard.isNeedToSearch && curCard.isFinishingSearch == true )
            {
                // 当不需要搜寻或者搜寻已完成时，执行卡牌的func操作
                curCard.func();
                curCard = null; // 执行完卡牌操作后，将卡牌置为null
                curCard.isFinishingSearch = false;
            }
        }
    }

    // 执行搜寻操作
    private void PerformSearchOperation()
    {
        List<plateData> p = new List<plateData>();
        //创建搜索列表
        if ( curCard.cardName.Equals("建设陆军") )
        {
            p = SearchOperation.Instance.SearchSetArmy(GameManager.Instance.roundManager.returnCurCountryName(),GameManager.Instance.plateMananger.returnAllPlateInfo(),GameManager.Instance.roundManager.returnCurCampName());
        }
        else if ( curCard.cardName.Equals("建设海军") )
        {
            p = SearchOperation.Instance.SearchSetNavy(GameManager.Instance.roundManager.returnCurCountryName(), GameManager.Instance.plateMananger.returnAllPlateInfo(),GameManager.Instance.roundManager.returnCurCampName());
        } 
        else if ( curCard.cardName.Equals("发起陆战") )
        {
        }
        else if ( curCard.cardName.Equals("发起海战") )
        {

        }


        if ( curCard.affectingTarget == "other" )
        {
            if( curCard.affectingTargetType == "Military")
            {
                curdMilitary =  GameManager.Instance.uIManager.selectedMilitary;
            }
            else if (curCard.affectingTargetType == "Plate")
            {
                curPlate = p.Contains(GameManager.Instance.uIManager.selectedPlate)
               ? GameManager.Instance.uIManager.selectedPlate
               : null;

            }
        }


    }

    // 用户点击确认按钮后，标记搜索完成
    private void OnConfirmClick()
    {
        curCard.isFinishingSearch = true;
    }
}
