using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Germany : Singleton<Germany>
{
    // ��ǰ����
    public string country = "Germany";
    // ������Ӫ
    public string camp = "Axis";
    // ʣ��½��
    public int army = 7;
    // ʣ�ຣ��
    public int navy = 3;
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
