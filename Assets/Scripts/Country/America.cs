using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class America : Singleton<America>
{
    // ��ǰ����
    public string country = "America";
    // ������Ӫ
    public string camp = "Allies";
    // ʣ��½��
    public int army = 5;
    // ʣ�ຣ��
    public int navy = 6;
    // ���ƶ�
    public List<Card> DiscardPile;
    // ʣ���ƶ�
    public List<Card> RemainPile;
    // ��ǰ����
    public List<Card> HandCards;
    // ��ǰ�ѹ�״̬��
    public List<Card> StatusCards;
    //��ǰ�ѹҶԲ���
    public List<Card> CountermeasuresCards;


    // Start is called before the first frame update
    void start()
    {
        DiscardPile = new List<Card>(); // ��ʼ�����ƶ�
        // ��ʼ��ʣ���ƶ�
        RemainPile = new List<Card>();
        // ��ʱʣ���ƶ�Ӧ���������Ƶļ���
        // ���������
        // ��������Ҫ���������Ϸ�߼�����ӿ��Ƶ�RemainPile

        HandCards = new List<Card>(); // ��ʼ������
        StatusCards = new List<Card>(); // ��ʼ��������
        CountermeasuresCards = new List<Card>(); // ��ʼ���Բ���
    }

    // Update is called once per frame
    void Update()
    {

    }
}

