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
    public List<GameObject> DiscardPile;
    // ʣ���ƶ�
    public List<GameObject> RemainPile;
    // ��ǰ����
    public List<GameObject> HandCards;
    // ��ǰ�ѹ�״̬��
    public List<GameObject> StatusCards;


    // Start is called before the first frame update
    void start()
    {
        DiscardPile = new List<GameObject>(); // ��ʼ�����ƶ�
        // ��ʼ��ʣ���ƶ�
        RemainPile = new List<GameObject>();
        // ��ʱʣ���ƶ�Ӧ���������Ƶļ���
        // ���������
        // ��������Ҫ���������Ϸ�߼�����ӿ��Ƶ�RemainPile

        HandCards = new List<GameObject>(); // ��ʼ������
        StatusCards = new List<GameObject>(); // ��ʼ��������
    }

    // Update is called once per frame
    void Update()
    {

    }
}

