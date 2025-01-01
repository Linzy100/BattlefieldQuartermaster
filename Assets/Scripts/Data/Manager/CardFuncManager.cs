using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CardFuncManager : Singleton<CardFuncManager>
{
    public Card curCard;
    public plateData curPlate;
    public string[] curdMilitary = new string[2];  // ���ڴ洢������Ϣ
    public Button confirmButton; // �����û�ȷ�ϵİ�ť
    private bool isWaitingForUserInput = false; // �Ƿ�ȴ��û�����


    public bool Germany1101()
    {
        //���ж��Ƿ���ѡ��ؿ�
        //�ж��ܷ���½��
        GameObject tipPanel = this.GetComponentInParent<Canvas>().transform.Find("TipPanel").gameObject;
        if (PlateClickHandler.selectedPlate == null)
        {
            tipPanel.SetActive(true);
            TipPanel.Instance.SetLogText("δѡ��ؿ飡");
            return false;
        }
        //Debug.Log(PlateClickHandler.selectedPlate.name);
        //return true;
        List<plateData> list=SearchOperation.Instance.SearchSetArmy(RoundManager.Instance.returnCurCountryName(), PlateManager.Instance.returnAllPlateInfo(), RoundManager.Instance.returnCurCampName());
        foreach(plateData plateData in list)
        {
            if(plateData.plateName.Equals(PlateClickHandler.selectedPlate.name))
            {
                //����½���޸�����
                CardManager.Instance.card1101.func("Germany", "Axis","Army",PlateClickHandler.selectedPlate.name);
                return true;
            }
        }
        tipPanel.SetActive(true);
        TipPanel.Instance.SetLogText("�õؿ鲻�ɽ���½����");
        return false;
    }
        



    //public void playCard()  //��ȡ����
    //{
    //    curCard = UIManager.Instance.selectedCard;
    //    // �����ǰ�п���
    //    if (curCard.cardName != null)
    //    {
    //        if (curCard.isNeedToSearch && curCard.isFinishingSearch == false)
    //        {
    //            // ִ����Ѱ����
    //            PerformSearchOperation();
    //            isWaitingForUserInput = true; // ����Ϊ�ȴ��û�����
    //        }
    //        else if (curCard.isNeedToSearch && curCard.isFinishingSearch == true)
    //        {
    //            // ������Ҫ��Ѱ������Ѱ�����ʱ��ִ�п��Ƶ�func����
    //            curCard.func();
    //            curCard = null; // ִ���꿨�Ʋ����󣬽�������Ϊnull
    //            curCard.isFinishingSearch = false;
    //        }
    //    }
    //}

    //private void Update()
    //{
        
    //}

    //// ִ����Ѱ����
    //private void PerformSearchOperation()
    //{
    //    List<plateData> p = new List<plateData>();
    //    //���������б�
    //    if (curCard.cardName.Equals("����½��"))
    //    {
    //        p = SearchOperation.Instance.SearchSetArmy(RoundManager.Instance.returnCurCountryName(), PlateManager.Instance.returnAllPlateInfo(), RoundManager.Instance.returnCurCampName());
    //    }
    //    else if (curCard.cardName.Equals("���躣��"))
    //    {
    //        p = SearchOperation.Instance.SearchSetNavy(RoundManager.Instance.returnCurCountryName(), PlateManager.Instance.returnAllPlateInfo(), RoundManager.Instance.returnCurCampName());
    //    }
    //    else if (curCard.cardName.Equals("����½ս"))
    //    {
    //    }
    //    else if (curCard.cardName.Equals("����ս"))
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

    //// �û����ȷ�ϰ�ť�󣬱���������
    //private void OnConfirmClick()
    //{
    //    curCard.isFinishingSearch = true;
    //}

}
