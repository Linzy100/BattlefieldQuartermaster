using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Italy : Singleton<Italy>
{
    // 当前国家
    public string country = "Italy";
    // 所属阵营
    public string camp = "Axis";
    // 剩余陆军
    public int army = 4;
    // 剩余海军
    public int navy = 3;
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
        CardManager.Instance.InitItalyCardPiles();
        CardManager.Instance.GetHandCardtoSeven(country);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
