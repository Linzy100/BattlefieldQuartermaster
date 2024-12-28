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
            CardPile.Add( new Card6101());
            CardPile.Add( new Card6102());
            CardPile.Add( new Card6103());
            CardPile.Add( new Card6104());

            CardPile.Add(new Card6201());
            CardPile.Add(new Card6202());
            CardPile.Add(new Card6203());
            CardPile.Add(new Card6204());
            CardPile.Add(new Card6205());
            CardPile.Add(new Card6206());
            CardPile.Add(new Card6207());
            CardPile.Add(new Card6208());
            CardPile.Add(new Card6209());

            CardPile.Add(new Card6301());
            CardPile.Add(new Card6302());
            CardPile.Add(new Card6303());
            CardPile.Add(new Card6304());
            CardPile.Add(new Card6305());
            CardPile.Add(new Card6306());
            CardPile.Add(new Card6307());

            CardPile.Add(new Card6501());
            CardPile.Add(new Card6502());
            CardPile.Add(new Card6503());
            CardPile.Add(new Card6504());
            CardPile.Add(new Card6505());

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
            HandCards.Add(CardPile[14]);//
            HandCards.Add(CardPile[15]);//
            StatusCards.Add(CardPile[12]);//
            StatusCards.Add(CardPile[13]);//
            CountermeasuresCards.Add(CardPile[10]);//
            CountermeasuresCards.Add(CardPile[11]);//
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

