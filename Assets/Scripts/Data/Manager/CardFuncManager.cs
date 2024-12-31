using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFuncManager : MonoBehaviour
{
    public Card curCard;
    public plateData curPlate;
    public string[] curdMilitary = new string[2];  // ���ڴ洢������Ϣ
    public Button confirmButton; // �����û�ȷ�ϵİ�ť
    private bool isWaitingForUserInput = false; // �Ƿ�ȴ��û�����


    public void playCard()  //��ȡ����
    {
        curCard = GameManager.Instance.uIManager.selectedCard;
    }

    private void Update()
    {
        // �����ǰ�п���
        if (curCard != null)
        {
            if (curCard.isNeedToSearch && curCard.isFinishingSearch == false )
            {
                // ִ����Ѱ����
                PerformSearchOperation();
                isWaitingForUserInput = true; // ����Ϊ�ȴ��û�����
            }
            else if (curCard.isNeedToSearch && curCard.isFinishingSearch == true )
            {
                // ������Ҫ��Ѱ������Ѱ�����ʱ��ִ�п��Ƶ�func����
                curCard.func();
                curCard = null; // ִ���꿨�Ʋ����󣬽�������Ϊnull
                curCard.isFinishingSearch = false;
            }
        }
    }

    // ִ����Ѱ����
    private void PerformSearchOperation()
    {
        List<plateData> p = new List<plateData>();
        //���������б�
        if ( curCard.cardName.Equals("����½��") )
        {
            p = SearchOperation.Instance.SearchSetArmy(GameManager.Instance.roundManager.returnCurCountryName(),GameManager.Instance.plateMananger.returnAllPlateInfo(),GameManager.Instance.roundManager.returnCurCampName());
        }
        else if ( curCard.cardName.Equals("���躣��") )
        {
            p = SearchOperation.Instance.SearchSetNavy(GameManager.Instance.roundManager.returnCurCountryName(), GameManager.Instance.plateMananger.returnAllPlateInfo(),GameManager.Instance.roundManager.returnCurCampName());
        } 
        else if ( curCard.cardName.Equals("����½ս") )
        {
        }
        else if ( curCard.cardName.Equals("����ս") )
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

    // �û����ȷ�ϰ�ť�󣬱���������
    private void OnConfirmClick()
    {
        curCard.isFinishingSearch = true;
    }
}
