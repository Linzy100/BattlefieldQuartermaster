using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Italy : Singleton<Italy>
{
    // ��ǰ����
    public string country = "Italy";
    // ������Ӫ
    public string camp = "Axis";
    // ʣ��½��
    public int army = 4;
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
        /*DiscardPile = new List<Card>(); // ��ʼ�����ƶ�
        CardPile = new List<Card>();//��ʼ�����ƶ�
        HandCards = new List<Card>(); // ��ʼ������
        StatusCards = new List<Card>(); // ��ʼ��������
        CountermeasuresCards = new List<Card>(); // ��ʼ���Բ���

        //���ƽ����ƶѣ������д���
        {
            CardPile.Add(new Card5101());
            CardPile.Add(new Card5102());
            CardPile.Add(new Card5103());
            CardPile.Add(new Card5104());

            CardPile.Add(new Card5201());
            CardPile.Add(new Card5202());
            CardPile.Add(new Card5203());
            CardPile.Add(new Card5204());
            CardPile.Add(new Card5205());
            CardPile.Add(new Card5206());

            CardPile.Add(new Card5301());
            CardPile.Add(new Card5302());
            CardPile.Add(new Card5303());
            CardPile.Add(new Card5304());
            CardPile.Add(new Card5305());

            CardPile.Add(new Card5401());
            CardPile.Add(new Card5402());
            CardPile.Add(new Card5403());
            CardPile.Add(new Card5404());

            CardPile.Add(new Card5501());
            CardPile.Add(new Card5502());
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
        //}*/
        CardManager.Instance.InitItalyCardPiles();
        CardManager.Instance.GetHandCardtoSeven(country);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
