using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Nation
{
    // ��ǰ����
    public string country;
    // ������Ӫ
    public string camp;
    // ʣ��½��
    public int army ;
    // ʣ�ຣ��
    public int navy;
    // ���ƶ�
    public List<Card> DiscardPile;
   // ���ƶ�
    public List<Card> CardPile;
    // ��ǰ����
    public List<Card> HandCards;
    // ��ǰ�ѹ�״̬��
    public List<Card> StatusCards;
    //��ǰ�ѹҶԲ���
    public List<Card> CountermeasuresCards;


    // Start is called before the first frame update
    public Nation()
    {
        DiscardPile = new List<Card>(); // ��ʼ�����ƶ�
        CardPile = new List<Card>(); // ��ʼ�����ƶ�
        HandCards = new List<Card>(); // ��ʼ������
        StatusCards = new List<Card>(); // ��ʼ��������
        CountermeasuresCards = new List<Card>(); // ��ʼ���Բ���
        //CardManager.Instance.InitCardPiles();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
