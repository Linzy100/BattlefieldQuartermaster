using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitedKingdom : Singleton<UnitedKingdom>
{
    // ��ǰ����
    public string country = "UnitedKingdom";
    // ������Ӫ
    public string camp = "Allies";
    // ʣ��½��
    public int army = 5;
    // ʣ�ຣ��
    public int navy = 5;
    // ���ƶ�
    public List<GameObject> DiscardPile;
    // ʣ���ƶ�
    public List<GameObject> RemainPile;
    // ��ǰ����
    public List<GameObject> HandCards;
    // ��ǰ�ѹ�״̬��
    public List<GameObject> StatusCards;
    //��ǰ�ѹҶԲ���
    public List<GameObject> CountermeasuresCards;


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
        CountermeasuresCards = new List<GameObject>();// ��ʼ���Բ���
    }

    // Update is called once per frame
    void Update()
    {

    }
}
