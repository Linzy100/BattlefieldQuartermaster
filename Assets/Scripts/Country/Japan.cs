using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Japan : Singleton<Japan>
{
    // ��ǰ����
    public string country = "Japan";
    // ������Ӫ
    public string camp = "Axis";
    // ʣ��½��
    public int army = 5;
    // ʣ�ຣ��
    public int navy = 5;
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
            CardPile.Add(new Card3101());
            CardPile.Add(new Card3102());
            CardPile.Add(new Card3103());
            CardPile.Add(new Card3104());

            CardPile.Add(new Card3301());
            CardPile.Add(new Card3302());
            CardPile.Add(new Card3303());
            CardPile.Add(new Card3304());

            CardPile.Add(new Card3401());
            CardPile.Add(new Card3402());
            CardPile.Add(new Card3403());
            CardPile.Add(new Card3404());
            CardPile.Add(new Card3405());
            CardPile.Add(new Card3406());
            CardPile.Add(new Card3407());
            CardPile.Add(new Card3408());
            CardPile.Add(new Card3409());
            CardPile.Add(new Card3410());
            CardPile.Add(new Card3411());

            CardPile.Add(new Card3501());
            CardPile.Add(new Card3502());
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
