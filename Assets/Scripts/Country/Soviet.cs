using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soviet : Singleton<Soviet>
{
    // 当前国家
    public string country = "Soviet";
    // 所属阵营
    public string camp = "Allies";
    // 剩余陆军
    public int army = 7;
    // 剩余海军
    public int navy = 1;
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
        CardManager.Instance.InitSovietCardPiles();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
