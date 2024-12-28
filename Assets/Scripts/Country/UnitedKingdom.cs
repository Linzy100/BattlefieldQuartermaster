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
            CardPile.Add(new Card2101());
            CardPile.Add(new Card2102());
            CardPile.Add(new Card2103());
            CardPile.Add(new Card2104());

            CardPile.Add(new Card2201());
            CardPile.Add(new Card2202());
            CardPile.Add(new Card2203());
            CardPile.Add(new Card2204());
            CardPile.Add(new Card2205());

            CardPile.Add(new Card2301());
            CardPile.Add(new Card2302());
            CardPile.Add(new Card2303());
            CardPile.Add(new Card2304());
            CardPile.Add(new Card2305());

            CardPile.Add(new Card2401());
            CardPile.Add(new Card2402());
            CardPile.Add(new Card2403());
            CardPile.Add(new Card2404());
            CardPile.Add(new Card2405());
            CardPile.Add(new Card2406());
            CardPile.Add(new Card2407());

            CardPile.Add(new Card2501());
            CardPile.Add(new Card2502());
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
        CardManager.Instance.InitUnitedKingdomCardPiles();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
