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
    public List<Card> DiscardPile;
    // ���ƶ�
    public List<Card> CardPile;
    // ��ǰ����
    public List<Card> HandCards;
    // ��ǰ�ѹ�״̬��
    public List<Card> StatusCards;
    //��ǰ�ѹҶԲ���
    public List<Card> CountermeasuresCards;

    private System.Random rng = new System.Random();


    // Start is called before the first frame update
    void Start()
    {
        DiscardPile = new List<Card>(); // ��ʼ�����ƶ�
        CardPile = new List<Card>();//��ʼ�����ƶ�
        HandCards = new List<Card>(); // ��ʼ������
        StatusCards = new List<Card>(); // ��ʼ��������
        CountermeasuresCards = new List<Card>(); // ��ʼ���Բ���

        //���ƽ����ƶѣ������д���
        {
            CardPile.Add(new Card1101());
            CardPile.Add(new Card1102());
            CardPile.Add(new Card1103());
            CardPile.Add(new Card1104());

            CardPile.Add(new Card1201());
            CardPile.Add(new Card1202());
            CardPile.Add(new Card1203());
            CardPile.Add(new Card1204());
            CardPile.Add(new Card1205());
            CardPile.Add(new Card1206());

            CardPile.Add(new Card1301());
            CardPile.Add(new Card1302());
            CardPile.Add(new Card1303());
            CardPile.Add(new Card1304());
            CardPile.Add(new Card1305());
            CardPile.Add(new Card1306());
            CardPile.Add(new Card1307());
            CardPile.Add(new Card1308());
            CardPile.Add(new Card1309());
            CardPile.Add(new Card1310());
            CardPile.Add(new Card1311());
            CardPile.Add(new Card1312());

            CardPile.Add(new Card1501());
            CardPile.Add(new Card1502());
            CardPile.Add(new Card1503());
            CardPile.Add(new Card1504());
            CardPile.Add(new Card1505());
            CardPile.Add(new Card1506());
        }
        // ʹ��Fisher-Yatesϴ���㷨���ҿ���˳��

        int n = CardPile.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card value = CardPile[k];
            CardPile[k] = CardPile[n];
            CardPile[n] = value;
        }

        //foreach (Card card in CardPile)
        //{
        //    Debug.Log(card.cardName);
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }
}
