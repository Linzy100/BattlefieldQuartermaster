using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : Singleton<CardManager>
{
    private System.Random rng = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitAmericaCardPiles()
    {
        America.Instance.DiscardPile = new List<Card>(); // 初始化弃牌堆
        America.Instance.CardPile = new List<Card>();//初始化抽牌堆
        America.Instance.HandCards = new List<Card>(); // 初始化手牌
        America.Instance.StatusCards = new List<Card>(); // 初始化局势牌
        America.Instance.CountermeasuresCards = new List<Card>(); // 初始化对策牌

        //放牌进抽牌堆，并进行打乱
        {
            America.Instance.CardPile.Add(new Card6101());
            America.Instance.CardPile.Add(new Card6102());
            America.Instance.CardPile.Add(new Card6103());
            America.Instance.CardPile.Add(new Card6104());

            America.Instance.CardPile.Add(new Card6201());
            America.Instance.CardPile.Add(new Card6202());
            America.Instance.CardPile.Add(new Card6203());
            America.Instance.CardPile.Add(new Card6204());
            America.Instance.CardPile.Add(new Card6205());
            America.Instance.CardPile.Add(new Card6206());
            America.Instance.CardPile.Add(new Card6207());
            America.Instance.CardPile.Add(new Card6208());
            America.Instance.CardPile.Add(new Card6209());

            America.Instance.CardPile.Add(new Card6301());
            America.Instance.CardPile.Add(new Card6302());
            America.Instance.CardPile.Add(new Card6303());
            America.Instance.CardPile.Add(new Card6304());
            America.Instance.CardPile.Add(new Card6305());
            America.Instance.CardPile.Add(new Card6306());
            America.Instance.CardPile.Add(new Card6307());

            America.Instance.CardPile.Add(new Card6501());
            America.Instance.CardPile.Add(new Card6502());
            America.Instance.CardPile.Add(new Card6503());
            America.Instance.CardPile.Add(new Card6504());
            America.Instance.CardPile.Add(new Card6505());

            // 使用Fisher-Yates洗牌算法打乱卡牌顺序

            int n = America.Instance.CardPile.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = America.Instance.CardPile[k];
                America.Instance.CardPile[k] = America.Instance.CardPile[n];
                America.Instance.CardPile[n] = value;
            }

            //foreach (Card card in CardPile)
            //{
            //    Debug.Log(card.cardName);
            //}
            America.Instance.HandCards.Add(America.Instance.CardPile[14]);//
            America.Instance.HandCards.Add(America.Instance.CardPile[15]);//
            America.Instance.StatusCards.Add(America.Instance.CardPile[12]);//
            America.Instance.StatusCards.Add(America.Instance.CardPile[13]);//
            America.Instance.CountermeasuresCards.Add(America.Instance.CardPile[10]);//
            America.Instance.CountermeasuresCards.Add(America.Instance.CardPile[11]);//
        }
    }

    public void InitSovietCardPiles()
    {
        Soviet.Instance.DiscardPile = new List<Card>(); // 初始化弃牌堆
        Soviet.Instance.CardPile = new List<Card>();//初始化抽牌堆
        Soviet.Instance.HandCards = new List<Card>(); // 初始化手牌
        Soviet.Instance.StatusCards = new List<Card>(); // 初始化局势牌
        Soviet.Instance.CountermeasuresCards = new List<Card>(); // 初始化对策牌

        //放牌进抽牌堆，并进行打乱
        {
            Soviet.Instance.CardPile.Add(new Card4101());
            Soviet.Instance.CardPile.Add(new Card4102());
            Soviet.Instance.CardPile.Add(new Card4103());
            Soviet.Instance.CardPile.Add(new Card4104());

            Soviet.Instance.CardPile.Add(new Card4201());
            Soviet.Instance.CardPile.Add(new Card4202());
            Soviet.Instance.CardPile.Add(new Card4203());
            Soviet.Instance.CardPile.Add(new Card4204());
            Soviet.Instance.CardPile.Add(new Card4205());
            Soviet.Instance.CardPile.Add(new Card4206());

            Soviet.Instance.CardPile.Add(new Card4301());
            Soviet.Instance.CardPile.Add(new Card4302());
            Soviet.Instance.CardPile.Add(new Card4303());
            Soviet.Instance.CardPile.Add(new Card4304());
            Soviet.Instance.CardPile.Add(new Card4305());
            Soviet.Instance.CardPile.Add(new Card4306());

            Soviet.Instance.CardPile.Add(new Card4401());
            Soviet.Instance.CardPile.Add(new Card4402());
            Soviet.Instance.CardPile.Add(new Card4403());
            Soviet.Instance.CardPile.Add(new Card4404());
            Soviet.Instance.CardPile.Add(new Card4405());
        }

        // 使用Fisher-Yates洗牌算法打乱卡牌顺序

        int n = Soviet.Instance.CardPile.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card value = Soviet.Instance.CardPile[k];
            Soviet.Instance.CardPile[k] = Soviet.Instance.CardPile[n];
            Soviet.Instance.CardPile[n] = value;
        }
    }

    public void InitUnitedKingdomCardPiles()
    {
        UnitedKingdom.Instance.DiscardPile = new List<Card>(); // 初始化弃牌堆
        UnitedKingdom.Instance.CardPile = new List<Card>();//初始化抽牌堆
        UnitedKingdom.Instance.HandCards = new List<Card>(); // 初始化手牌
        UnitedKingdom.Instance.StatusCards = new List<Card>(); // 初始化局势牌
        UnitedKingdom.Instance.CountermeasuresCards = new List<Card>(); // 初始化对策牌

        //放牌进抽牌堆，并进行打乱
        {
            UnitedKingdom.Instance.CardPile.Add(new Card2101());
            UnitedKingdom.Instance.CardPile.Add(new Card2102());
            UnitedKingdom.Instance.CardPile.Add(new Card2103());
            UnitedKingdom.Instance.CardPile.Add(new Card2104());

            UnitedKingdom.Instance.CardPile.Add(new Card2201());
            UnitedKingdom.Instance.CardPile.Add(new Card2202());
            UnitedKingdom.Instance.CardPile.Add(new Card2203());
            UnitedKingdom.Instance.CardPile.Add(new Card2204());
            UnitedKingdom.Instance.CardPile.Add(new Card2205());

            UnitedKingdom.Instance.CardPile.Add(new Card2301());
            UnitedKingdom.Instance.CardPile.Add(new Card2302());
            UnitedKingdom.Instance.CardPile.Add(new Card2303());
            UnitedKingdom.Instance.CardPile.Add(new Card2304());
            UnitedKingdom.Instance.CardPile.Add(new Card2305());

            UnitedKingdom.Instance.CardPile.Add(new Card2401());
            UnitedKingdom.Instance.CardPile.Add(new Card2402());
            UnitedKingdom.Instance.CardPile.Add(new Card2403());
            UnitedKingdom.Instance.CardPile.Add(new Card2404());
            UnitedKingdom.Instance.CardPile.Add(new Card2405());
            UnitedKingdom.Instance.CardPile.Add(new Card2406());
            UnitedKingdom.Instance.CardPile.Add(new Card2407());

            UnitedKingdom.Instance.CardPile.Add(new Card2501());
            UnitedKingdom.Instance.CardPile.Add(new Card2502());
        }
        // 使用Fisher-Yates洗牌算法打乱卡牌顺序

        int n = UnitedKingdom.Instance.CardPile.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card value = UnitedKingdom.Instance.CardPile[k];
            UnitedKingdom.Instance.CardPile[k] = UnitedKingdom.Instance.CardPile[n];
            UnitedKingdom.Instance.CardPile[n] = value;
        }
    }

    public void InitGermanyCardPiles()
    {
        Germany.Instance.DiscardPile = new List<Card>(); // 初始化弃牌堆
        Germany.Instance.CardPile = new List<Card>();//初始化抽牌堆
        Germany.Instance.HandCards = new List<Card>(); // 初始化手牌
        Germany.Instance.StatusCards = new List<Card>(); // 初始化局势牌
        Germany.Instance.CountermeasuresCards = new List<Card>(); // 初始化对策牌

        //放牌进抽牌堆，并进行打乱
        {
            Germany.Instance.CardPile.Add(new Card1101());
            Germany.Instance.CardPile.Add(new Card1102());
            Germany.Instance.CardPile.Add(new Card1103());
            Germany.Instance.CardPile.Add(new Card1104());

            Germany.Instance.CardPile.Add(new Card1201());
            Germany.Instance.CardPile.Add(new Card1202());
            Germany.Instance.CardPile.Add(new Card1203());
            Germany.Instance.CardPile.Add(new Card1204());
            Germany.Instance.CardPile.Add(new Card1205());
            Germany.Instance.CardPile.Add(new Card1206());

            Germany.Instance.CardPile.Add(new Card1301());
            Germany.Instance.CardPile.Add(new Card1302());
            Germany.Instance.CardPile.Add(new Card1303());
            Germany.Instance.CardPile.Add(new Card1304());
            Germany.Instance.CardPile.Add(new Card1305());
            Germany.Instance.CardPile.Add(new Card1306());
            Germany.Instance.CardPile.Add(new Card1307());
            Germany.Instance.CardPile.Add(new Card1308());
            Germany.Instance.CardPile.Add(new Card1309());
            Germany.Instance.CardPile.Add(new Card1310());
            Germany.Instance.CardPile.Add(new Card1311());
            Germany.Instance.CardPile.Add(new Card1312());

            Germany.Instance.CardPile.Add(new Card1501());
            Germany.Instance.CardPile.Add(new Card1502());
            Germany.Instance.CardPile.Add(new Card1503());
            Germany.Instance.CardPile.Add(new Card1504());
            Germany.Instance.CardPile.Add(new Card1505());
            Germany.Instance.CardPile.Add(new Card1506());
        }
        // 使用Fisher-Yates洗牌算法打乱卡牌顺序

        int n = Germany.Instance.CardPile.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card value = Germany.Instance.CardPile[k];
            Germany.Instance.CardPile[k] = Germany.Instance.CardPile[n];
            Germany.Instance.CardPile[n] = value;
        }
    }

    public void InitJapanCardPiles()
    {
        Japan.Instance.DiscardPile = new List<Card>(); // 初始化弃牌堆
        Japan.Instance.CardPile = new List<Card>();//初始化抽牌堆
        Japan.Instance.HandCards = new List<Card>(); // 初始化手牌
        Japan.Instance.StatusCards = new List<Card>(); // 初始化局势牌
        Japan.Instance.CountermeasuresCards = new List<Card>(); // 初始化对策牌

        //放牌进抽牌堆，并进行打乱
        {
            Japan.Instance.CardPile.Add(new Card3101());
            Japan.Instance.CardPile.Add(new Card3102());
            Japan.Instance.CardPile.Add(new Card3103());
            Japan.Instance.CardPile.Add(new Card3104());

            Japan.Instance.CardPile.Add(new Card3301());
            Japan.Instance.CardPile.Add(new Card3302());
            Japan.Instance.CardPile.Add(new Card3303());
            Japan.Instance.CardPile.Add(new Card3304());

            Japan.Instance.CardPile.Add(new Card3401());
            Japan.Instance.CardPile.Add(new Card3402());
            Japan.Instance.CardPile.Add(new Card3403());
            Japan.Instance.CardPile.Add(new Card3404());
            Japan.Instance.CardPile.Add(new Card3405());
            Japan.Instance.CardPile.Add(new Card3406());
            Japan.Instance.CardPile.Add(new Card3407());
            Japan.Instance.CardPile.Add(new Card3408());
            Japan.Instance.CardPile.Add(new Card3409());
            Japan.Instance.CardPile.Add(new Card3410());
            Japan.Instance.CardPile.Add(new Card3411());

            Japan.Instance.CardPile.Add(new Card3501());
            Japan.Instance.CardPile.Add(new Card3502());
        }
        // 使用Fisher-Yates洗牌算法打乱卡牌顺序

        int n = Japan.Instance.CardPile.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card value = Japan.Instance.CardPile[k];
            Japan.Instance.CardPile[k] = Japan.Instance.CardPile[n];
            Japan.Instance.CardPile[n] = value;
        }
    }

    public void InitItalyCardPiles()
    {
        Italy.Instance.DiscardPile = new List<Card>(); // 初始化弃牌堆
        Italy.Instance.CardPile = new List<Card>();//初始化抽牌堆
        Italy.Instance.HandCards = new List<Card>(); // 初始化手牌
        Italy.Instance.StatusCards = new List<Card>(); // 初始化局势牌
        Italy.Instance.CountermeasuresCards = new List<Card>(); // 初始化对策牌

        //放牌进抽牌堆，并进行打乱
        {
            Italy.Instance.CardPile.Add(new Card5101());
            Italy.Instance.CardPile.Add(new Card5102());
            Italy.Instance.CardPile.Add(new Card5103());
            Italy.Instance.CardPile.Add(new Card5104());

            Italy.Instance.CardPile.Add(new Card5201());
            Italy.Instance.CardPile.Add(new Card5202());
            Italy.Instance.CardPile.Add(new Card5203());
            Italy.Instance.CardPile.Add(new Card5204());
            Italy.Instance.CardPile.Add(new Card5205());
            Italy.Instance.CardPile.Add(new Card5206());

            Italy.Instance.CardPile.Add(new Card5301());
            Italy.Instance.CardPile.Add(new Card5302());
            Italy.Instance.CardPile.Add(new Card5303());
            Italy.Instance.CardPile.Add(new Card5304());
            Italy.Instance.CardPile.Add(new Card5305());

            Italy.Instance.CardPile.Add(new Card5401());
            Italy.Instance.CardPile.Add(new Card5402());
            Italy.Instance.CardPile.Add(new Card5403());
            Italy.Instance.CardPile.Add(new Card5404());

            Italy.Instance.CardPile.Add(new Card5501());
            Italy.Instance.CardPile.Add(new Card5502());
        }
        // 使用Fisher-Yates洗牌算法打乱卡牌顺序

        int n = Italy.Instance.CardPile.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card value = Italy.Instance.CardPile[k];
            Italy.Instance.CardPile[k] = Italy.Instance.CardPile[n];
            Italy.Instance.CardPile[n] = value;
        }
    }
}
