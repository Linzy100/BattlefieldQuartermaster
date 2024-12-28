using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soviet : Singleton<Soviet>
{
    // ��ǰ����
    public string country = "Soviet";
    // ������Ӫ
    public string camp = "Allies";
    // ʣ��½��
    public int army = 7;
    // ʣ�ຣ��
    public int navy = 1;
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
            CardPile.Add(new Card4101());
            CardPile.Add(new Card4102());
            CardPile.Add(new Card4103());
            CardPile.Add(new Card4104());

            CardPile.Add(new Card4201());
            CardPile.Add(new Card4202());
            CardPile.Add(new Card4203());
            CardPile.Add(new Card4204());
            CardPile.Add(new Card4205());
            CardPile.Add(new Card4206());

            CardPile.Add(new Card4301());
            CardPile.Add(new Card4302());
            CardPile.Add(new Card4303());
            CardPile.Add(new Card4304());
            CardPile.Add(new Card4305());
            CardPile.Add(new Card4306());

            CardPile.Add(new Card4401());
            CardPile.Add(new Card4402());
            CardPile.Add(new Card4403());
            CardPile.Add(new Card4404());
            CardPile.Add(new Card4405());
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
        CardManager.Instance.InitSovietCardPiles();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
