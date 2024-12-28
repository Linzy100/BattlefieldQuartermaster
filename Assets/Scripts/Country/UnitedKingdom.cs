using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitedKingdom : Singleton<UnitedKingdom>
{
    // 当前国家
    public string country = "UnitedKingdom";
    // 所属阵营
    public string camp = "Allies";
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
        /*DiscardPile = new List<Card>(); // 初始化弃牌堆
        CardPile = new List<Card>();//初始化抽牌堆
        HandCards = new List<Card>(); // 初始化手牌
        StatusCards = new List<Card>(); // 初始化局势牌
        CountermeasuresCards = new List<Card>(); // 初始化对策牌

        //放牌进抽牌堆，并进行打乱
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
        //}*/
        CardManager.Instance.InitUnitedKingdomCardPiles();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
