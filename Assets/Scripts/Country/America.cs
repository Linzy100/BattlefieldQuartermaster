using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class America : Singleton<America>
{
    // 当前国家
    public string country = "America";
    // 所属阵营
    public string camp = "Allies";
    // 剩余陆军
    public int army = 5;
    // 剩余海军
    public int navy = 6;
    // 弃牌堆
    public List<Card> DiscardPile;
    // 抽牌堆
    public List<Card> CardPile;
    // 当前手牌
    public List<Card> HandCards;
    // 当前已挂状态牌
    public List<Card> StatusCards;
    //当前已挂对策牌
    public List<Card> CountermeasuresCards;

    private System.Random rng = new System.Random();


    // Start is called before the first frame update
    void Start()
    {
        DiscardPile = new List<Card>(); // 初始化弃牌堆
        CardPile = new List<Card>();//初始化抽牌堆
        HandCards = new List<Card>(); // 初始化手牌
        StatusCards = new List<Card>(); // 初始化局势牌
        CountermeasuresCards = new List<Card>(); // 初始化对策牌

        //放牌进抽牌堆，并进行打乱
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

            // 使用Fisher-Yates洗牌算法打乱卡牌顺序

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

