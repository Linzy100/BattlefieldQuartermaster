using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Germany : Singleton<Germany>
{
    // 当前国家
    public string country = "Germany";
    // 所属阵营
    public string camp = "Axis";
    // 剩余陆军
    public int army = 7;
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
        DiscardPile = new List<Card>(); // 初始化弃牌堆
        CardPile = new List<Card>();//初始化抽牌堆
        HandCards = new List<Card>(); // 初始化手牌
        StatusCards = new List<Card>(); // 初始化局势牌
        CountermeasuresCards = new List<Card>(); // 初始化对策牌

        //放牌进抽牌堆，并进行打乱
        {
            CardPile.Add(new Card1101());
            CardPile.Add(new Card1102());
            CardPile.Add(new Card1103());
            CardPile.Add(new Card1104());

            CardPile.Add(new Card1201());
            CardPile.Add(new Card1202());
            CardPile.Add(new Card1203());
            CardPile.Add(new Card1204());
            CardPile.Add(new Card1205());
            CardPile.Add(new Card1206());

            CardPile.Add(new Card1301());
            CardPile.Add(new Card1302());
            CardPile.Add(new Card1303());
            CardPile.Add(new Card1304());
            CardPile.Add(new Card1305());
            CardPile.Add(new Card1306());
            CardPile.Add(new Card1307());
            CardPile.Add(new Card1308());
            CardPile.Add(new Card1309());
            CardPile.Add(new Card1310());
            CardPile.Add(new Card1311());
            CardPile.Add(new Card1312());

            CardPile.Add(new Card1501());
            CardPile.Add(new Card1502());
            CardPile.Add(new Card1503());
            CardPile.Add(new Card1504());
            CardPile.Add(new Card1505());
            CardPile.Add(new Card1506());
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
