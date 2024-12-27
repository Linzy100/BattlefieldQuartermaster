using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Japan : Singleton<Japan>
{
    // 当前国家
    public string country = "Japan";
    // 所属阵营
    public string camp = "Axis";
    // 剩余陆军
    public int army = 5;
    // 剩余海军
    public int navy = 5;
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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
