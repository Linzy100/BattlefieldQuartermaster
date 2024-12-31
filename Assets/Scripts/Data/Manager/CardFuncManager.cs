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
        if ( curCard.affectingTarget == "other" )
        {
            if( curCard.affectingTargetType == "Military")
            {
                curdMilitary =  GameManager.Instance.uIManager.selectedMilitary;
            }
            else if (curCard.affectingTargetType == "Plate")
            {
                curPlate = GameManager.Instance.uIManager.selectedPlate;
            }
        }


    }

    // �û����ȷ�ϰ�ť�󣬱���������
    private void OnConfirmClick()
    {
        curCard.isFinishingSearch = true;
    }
}
