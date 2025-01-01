using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : Singleton<CardManager>
{
    public Card cardDatas;

    #region
    //德国卡牌
    public Card1101 card1101;
    public Card1102 card1102;
    public Card1103 card1103;
    public Card1104 card1104;
    public Card1201 card1201;
    public Card1202 card1202;
    public Card1203 card1203;
    public Card1204 card1204;
    public Card1205 card1205;
    public Card1206 card1206;
    public Card1301 card1301;
    public Card1302 card1302;
    public Card1303 card1303;
    public Card1304 card1304;
    public Card1305 card1305;
    public Card1306 card1306;
    public Card1307 card1307;
    public Card1308 card1308;
    public Card1309 card1309;
    public Card1310 card1310;
    public Card1311 card1311;
    public Card1312 card1312;
    public Card1501 card1501;
    public Card1502 card1502;
    public Card1503 card1503;
    public Card1504 card1504;
    public Card1505 card1505;
    public Card1506 card1506;
    //英国卡牌
    public Card2101 card2101;
    public Card2102 card2102;
    public Card2103 card2103;
    public Card2104 card2104;
    public Card2201 card2201;
    public Card2202 card2202;
    public Card2203 card2203;
    public Card2204 card2204;
    public Card2205 card2205;
    public Card2301 card2301;
    public Card2302 card2302;
    public Card2303 card2303;
    public Card2304 card2304;
    public Card2305 card2305;
    public Card2401 card2401;
    public Card2402 card2402;
    public Card2403 card2403;
    public Card2404 card2404;
    public Card2405 card2405;
    public Card2406 card2406;
    public Card2407 card2407;
    public Card2501 card2501;
    public Card2502 card2502;
    //日本卡牌
    public Card3101 card3101;
    public Card3102 card3102;
    public Card3103 card3103;
    public Card3104 card3104;
    public Card3301 card3301;
    public Card3302 card3302;
    public Card3303 card3303;
    public Card3304 card3304;
    public Card3401 card3401;
    public Card3402 card3402;
    public Card3403 card3403;
    public Card3404 card3404;
    public Card3405 card3405;
    public Card3406 card3406;
    public Card3407 card3407;
    public Card3408 card3408;
    public Card3409 card3409;
    public Card3410 card3410;
    public Card3411 card3411;
    public Card3501 card3501;
    public Card3502 card3502;
    //苏联卡牌
    public Card4101 card4101;
    public Card4102 card4102;
    public Card4103 card4103;
    public Card4104 card4104;
    public Card4201 card4201;
    public Card4202 card4202;
    public Card4203 card4203;
    public Card4204 card4204;
    public Card4205 card4205;
    public Card4206 card4206;
    public Card4301 card4301;
    public Card4302 card4302;
    public Card4303 card4303;
    public Card4304 card4304;
    public Card4305 card4305;
    public Card4306 card4306;
    public Card4401 card4401;
    public Card4402 card4402;
    public Card4403 card4403;
    public Card4404 card4404;
    public Card4405 card4405;
    //意大利卡牌
    public Card5101 card5101;
    public Card5102 card5102;
    public Card5103 card5103;
    public Card5104 card5104;
    public Card5201 card5201;
    public Card5202 card5202;
    public Card5203 card5203;
    public Card5204 card5204;
    public Card5205 card5205;
    public Card5206 card5206;
    public Card5301 card5301;
    public Card5302 card5302;
    public Card5304 card5304;
    public Card5305 card5305;
    public Card5401 card5401;
    public Card5402 card5402;
    public Card5403 card5403;
    public Card5404 card5404;
    public Card5501 card5501;
    public Card5502 card5502;
    //美国卡牌
    public Card6101 card6101;
    public Card6102 card6102;
    public Card6103 card6103;
    public Card6104 card6104;
    public Card6201 card6201;
    public Card6202 card6202;
    public Card6203 card6203;
    public Card6204 card6204;
    public Card6205 card6205;
    public Card6206 card6206;
    public Card6207 card6207;
    public Card6208 card6208;
    public Card6209 card6209;
    public Card6301 card6301;
    public Card6302 card6302;
    public Card6303 card6303;
    public Card6304 card6304;
    public Card6305 card6305;
    public Card6306 card6306;
    public Card6307 card6307;
    public Card6501 card6501;
    public Card6502 card6502;
    public Card6503 card6503;
    public Card6504 card6504;
    public Card6505 card6505;
    #endregion

    private List<Card> cardList = new List<Card>();
    private System.Random rng = new System.Random(); 



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
            America.Instance.CardPile.Add(new Card6101());
            America.Instance.CardPile.Add(new Card6101());
            America.Instance.CardPile.Add(new Card6101());
            America.Instance.CardPile.Add(new Card6101());
            America.Instance.CardPile.Add(new Card6102());
            America.Instance.CardPile.Add(new Card6102());
            America.Instance.CardPile.Add(new Card6102());
            America.Instance.CardPile.Add(new Card6102());
            America.Instance.CardPile.Add(new Card6103());
            America.Instance.CardPile.Add(new Card6103());
            America.Instance.CardPile.Add(new Card6103());
            America.Instance.CardPile.Add(new Card6103());
            America.Instance.CardPile.Add(new Card6103());
            America.Instance.CardPile.Add(new Card6104());
            America.Instance.CardPile.Add(new Card6104());
            America.Instance.CardPile.Add(new Card6104());
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
            Soviet.Instance.CardPile.Add(new Card4101());
            Soviet.Instance.CardPile.Add(new Card4101());
            Soviet.Instance.CardPile.Add(new Card4101());
            Soviet.Instance.CardPile.Add(new Card4101());
            Soviet.Instance.CardPile.Add(new Card4101());
            Soviet.Instance.CardPile.Add(new Card4101());
            Soviet.Instance.CardPile.Add(new Card4101());
            Soviet.Instance.CardPile.Add(new Card4102());
            Soviet.Instance.CardPile.Add(new Card4102());
            Soviet.Instance.CardPile.Add(new Card4102());
            Soviet.Instance.CardPile.Add(new Card4102());
            Soviet.Instance.CardPile.Add(new Card4102());
            Soviet.Instance.CardPile.Add(new Card4102());
            Soviet.Instance.CardPile.Add(new Card4103());
            Soviet.Instance.CardPile.Add(new Card4104());
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
            UnitedKingdom.Instance.CardPile.Add(new Card2101());
            UnitedKingdom.Instance.CardPile.Add(new Card2101());
            UnitedKingdom.Instance.CardPile.Add(new Card2101());
            UnitedKingdom.Instance.CardPile.Add(new Card2101());
            UnitedKingdom.Instance.CardPile.Add(new Card2102());
            UnitedKingdom.Instance.CardPile.Add(new Card2102());
            UnitedKingdom.Instance.CardPile.Add(new Card2102());
            UnitedKingdom.Instance.CardPile.Add(new Card2102());
            UnitedKingdom.Instance.CardPile.Add(new Card2103());
            UnitedKingdom.Instance.CardPile.Add(new Card2103());
            UnitedKingdom.Instance.CardPile.Add(new Card2103());
            UnitedKingdom.Instance.CardPile.Add(new Card2103());
            UnitedKingdom.Instance.CardPile.Add(new Card2103());
            UnitedKingdom.Instance.CardPile.Add(new Card2104());
            UnitedKingdom.Instance.CardPile.Add(new Card2104());
            UnitedKingdom.Instance.CardPile.Add(new Card2104());
            UnitedKingdom.Instance.CardPile.Add(new Card2104());
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
            Germany.Instance.CardPile.Add(new Card1101());
            Germany.Instance.CardPile.Add(new Card1101());
            Germany.Instance.CardPile.Add(new Card1101());
            Germany.Instance.CardPile.Add(new Card1101());
            Germany.Instance.CardPile.Add(new Card1101());
            Germany.Instance.CardPile.Add(new Card1102());
            Germany.Instance.CardPile.Add(new Card1102());
            Germany.Instance.CardPile.Add(new Card1102());
            Germany.Instance.CardPile.Add(new Card1102());
            Germany.Instance.CardPile.Add(new Card1102());
            Germany.Instance.CardPile.Add(new Card1102());
            Germany.Instance.CardPile.Add(new Card1102());
            Germany.Instance.CardPile.Add(new Card1103());
            Germany.Instance.CardPile.Add(new Card1103());
            Germany.Instance.CardPile.Add(new Card1104());
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
            Japan.Instance.CardPile.Add(new Card3101());
            Japan.Instance.CardPile.Add(new Card3101());
            Japan.Instance.CardPile.Add(new Card3101());
            Japan.Instance.CardPile.Add(new Card3102());
            Japan.Instance.CardPile.Add(new Card3102());
            Japan.Instance.CardPile.Add(new Card3102());
            Japan.Instance.CardPile.Add(new Card3103());
            Japan.Instance.CardPile.Add(new Card3103());
            Japan.Instance.CardPile.Add(new Card3103());
            Japan.Instance.CardPile.Add(new Card3103());
            Japan.Instance.CardPile.Add(new Card3103());
            Japan.Instance.CardPile.Add(new Card3103());
            Japan.Instance.CardPile.Add(new Card3104());
            Japan.Instance.CardPile.Add(new Card3104());
            Japan.Instance.CardPile.Add(new Card3104());
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
            Italy.Instance.CardPile.Add(new Card5101());
            Italy.Instance.CardPile.Add(new Card5101());
            Italy.Instance.CardPile.Add(new Card5101());
            Italy.Instance.CardPile.Add(new Card5102());
            Italy.Instance.CardPile.Add(new Card5102());
            Italy.Instance.CardPile.Add(new Card5102());
            Italy.Instance.CardPile.Add(new Card5102());
            Italy.Instance.CardPile.Add(new Card5103());
            Italy.Instance.CardPile.Add(new Card5103());
            Italy.Instance.CardPile.Add(new Card5103());
            Italy.Instance.CardPile.Add(new Card5104());
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



    // Start is called before the first frame update
    void Awake()
    {
        #region
        card1101 = new Card1101();
        card1102 = new Card1102();
        card1103 = new Card1103();
        card1104 = new Card1104();
        card1201 = new Card1201();
        card1202 = new Card1202();
        card1203 = new Card1203();
        card1204 = new Card1204();
        card1205 = new Card1205();
        card1206 = new Card1206();
        card1301 = new Card1301();
        card1302 = new Card1302();
        card1303 = new Card1303();
        card1304 = new Card1304();
        card1305 = new Card1305();
        card1306 = new Card1306();
        card1307 = new Card1307();
        card1308 = new Card1308();
        card1309 = new Card1309();
        card1310 = new Card1310();
        card1311 = new Card1311();
        card1312 = new Card1312();
        card1501 = new Card1501();
        card1502 = new Card1502();
        card1503 = new Card1503();
        card1504 = new Card1504();
        card1505 = new Card1505();
        card1506 = new Card1506();

        card2101 = new Card2101();
        card2102 = new Card2102();
        card2103 = new Card2103();
        card2104 = new Card2104();
        card2201 = new Card2201();
        card2202 = new Card2202();
        card2203 = new Card2203();
        card2204 = new Card2204();
        card2205 = new Card2205();
        card2301 = new Card2301();
        card2302 = new Card2302();
        card2303 = new Card2303();
        card2304 = new Card2304();
        card2305 = new Card2305();
        card2401 = new Card2401();
        card2402 = new Card2402();
        card2403 = new Card2403();
        card2404 = new Card2404();
        card2405 = new Card2405();
        card2406 = new Card2406();
        card2407 = new Card2407();
        card2501 = new Card2501();
        card2502 = new Card2502();

        card3101 = new Card3101();
        card3102 = new Card3102();
        card3103 = new Card3103();
        card3104 = new Card3104();
        card3301 = new Card3301();
        card3302 = new Card3302();
        card3303 = new Card3303();
        card3304 = new Card3304();
        card3401 = new Card3401();
        card3402 = new Card3402();
        card3403 = new Card3403();
        card3404 = new Card3404();
        card3405 = new Card3405();
        card3406 = new Card3406();
        card3407 = new Card3407();
        card3408 = new Card3408();
        card3409 = new Card3409();
        card3410 = new Card3410();
        card3411 = new Card3411();
        card3501 = new Card3501();
        card3502 = new Card3502();

        card4101 = new Card4101();
        card4102 = new Card4102();
        card4103 = new Card4103();
        card4104 = new Card4104();
        card4201 = new Card4201();
        card4202 = new Card4202();
        card4203 = new Card4203();
        card4204 = new Card4204();
        card4205 = new Card4205();
        card4206 = new Card4206();
        card4301 = new Card4301();
        card4302 = new Card4302();
        card4303 = new Card4303();
        card4304 = new Card4304();
        card4305 = new Card4305();
        card4306 = new Card4306();
        card4401 = new Card4401();
        card4402 = new Card4402();
        card4403 = new Card4403();
        card4404 = new Card4404();
        card4405 = new Card4405();

        card5101 = new Card5101();
        card5102 = new Card5102();
        card5103 = new Card5103();
        card5104 = new Card5104();
        card5201 = new Card5201();
        card5202 = new Card5202();
        card5203 = new Card5203();
        card5204 = new Card5204();
        card5205 = new Card5205();
        card5206 = new Card5206();
        card5301 = new Card5301();
        card5302 = new Card5302();
        card5304 = new Card5304();
        card5305 = new Card5305();
        card5401 = new Card5401();
        card5402 = new Card5402();
        card5403 = new Card5403();
        card5404 = new Card5404();
        card5501 = new Card5501();
        card5502 = new Card5502();

        card6101 = new Card6101();
        card6102 = new Card6102();
        card6103 = new Card6103();
        card6104 = new Card6104();
        card6201 = new Card6201();
        card6202 = new Card6202();
        card6203 = new Card6203();
        card6204 = new Card6204();
        card6205 = new Card6205();
        card6206 = new Card6206();
        card6207 = new Card6207();
        card6208 = new Card6208();
        card6209 = new Card6209();
        card6301 = new Card6301();
        card6302 = new Card6302();
        card6303 = new Card6303();
        card6304 = new Card6304();
        card6305 = new Card6305();
        card6306 = new Card6306();
        card6307 = new Card6307();
        card6501 = new Card6501();
        card6502 = new Card6502();
        card6503 = new Card6503();
        card6504 = new Card6504();
        card6505 = new Card6505();
        #endregion
        AddCardsToList();
    }

    public void AddCardsToList()
    {
        cardList.Add(card1101);
        cardList.Add(card1102);
        cardList.Add(card1103);
        cardList.Add(card1104);
        cardList.Add(card1201);
        cardList.Add(card1202);
        cardList.Add(card1203);
        cardList.Add(card1204);
        cardList.Add(card1205);
        cardList.Add(card1206);
        cardList.Add(card1301);
        cardList.Add(card1302);
        cardList.Add(card1303);
        cardList.Add(card1304);
        cardList.Add(card1305);
        cardList.Add(card1306);
        cardList.Add(card1307);
        cardList.Add(card1308);
        cardList.Add(card1309);
        cardList.Add(card1310);
        cardList.Add(card1311);
        cardList.Add(card1312);
        cardList.Add(card1501);
        cardList.Add(card1502);
        cardList.Add(card1503);
        cardList.Add(card1504);
        cardList.Add(card1505);
        cardList.Add(card1506);
        cardList.Add(card2101);
        cardList.Add(card2102);
        cardList.Add(card2103);
        cardList.Add(card2104);
        cardList.Add(card2201);
        cardList.Add(card2202);
        cardList.Add(card2203);
        cardList.Add(card2204);
        cardList.Add(card2205);
        cardList.Add(card2301);
        cardList.Add(card2302);
        cardList.Add(card2303);
        cardList.Add(card2304);
        cardList.Add(card2305);
        cardList.Add(card2401);
        cardList.Add(card2402);
        cardList.Add(card2403);
        cardList.Add(card2404);
        cardList.Add(card2405);
        cardList.Add(card2406);
        cardList.Add(card2407);
        cardList.Add(card2501);
        cardList.Add(card2502);
        cardList.Add(card3101);
        cardList.Add(card3102);
        cardList.Add(card3103);
        cardList.Add(card3104);
        cardList.Add(card3301);
        cardList.Add(card3302);
        cardList.Add(card3303);
        cardList.Add(card3304);
        cardList.Add(card3401);
        cardList.Add(card3402);
        cardList.Add(card3403);
        cardList.Add(card3404);
        cardList.Add(card3405);
        cardList.Add(card3406);
        cardList.Add(card3407);
        cardList.Add(card3408);
        cardList.Add(card3409);
        cardList.Add(card3410);
        cardList.Add(card3411);
        cardList.Add(card3501);
        cardList.Add(card3502);
        cardList.Add(card4101);
        cardList.Add(card4102);
        cardList.Add(card4103);
        cardList.Add(card4104);
        cardList.Add(card4201);
        cardList.Add(card4202);
        cardList.Add(card4203);
        cardList.Add(card4204);
        cardList.Add(card4205);
        cardList.Add(card4206);
        cardList.Add(card4301);
        cardList.Add(card4302);
        cardList.Add(card4303);
        cardList.Add(card4304);
        cardList.Add(card4305);
        cardList.Add(card4306);
        cardList.Add(card4401);
        cardList.Add(card4402);
        cardList.Add(card4403);
        cardList.Add(card4404);
        cardList.Add(card4405);
        cardList.Add(card5101);
        cardList.Add(card5102);
        cardList.Add(card5103);
        cardList.Add(card5104);
        cardList.Add(card5201);
        cardList.Add(card5202);
        cardList.Add(card5203);
        cardList.Add(card5204);
        cardList.Add(card5205);
        cardList.Add(card5206);
        cardList.Add(card5301);
        cardList.Add(card5302);
        cardList.Add(card5304);
        cardList.Add(card5305);
        cardList.Add(card5401);
        cardList.Add(card5402);
        cardList.Add(card5403);
        cardList.Add(card5404);
        cardList.Add(card5501);
        cardList.Add(card5502);
        cardList.Add(card6101);
        cardList.Add(card6102);
        cardList.Add(card6103);
        cardList.Add(card6104);
        cardList.Add(card6201);
        cardList.Add(card6202);
        cardList.Add(card6203);
        cardList.Add(card6204);
        cardList.Add(card6205);
        cardList.Add(card6206);
        cardList.Add(card6207);
        cardList.Add(card6208);
        cardList.Add(card6209);
        cardList.Add(card6301);
        cardList.Add(card6302);
        cardList.Add(card6303);
        cardList.Add(card6304);
        cardList.Add(card6305);
        cardList.Add(card6306);
        cardList.Add(card6307);
        cardList.Add(card6501);
        cardList.Add(card6502);
        cardList.Add(card6503);
        cardList.Add(card6504);
        cardList.Add(card6505);
    }


    public void GetHandCardtoSeven(string country)
    {
        List<Card> handCards = new List<Card>();
        switch (country)
        {
            case "America":
                {
                    handCards = America.Instance.HandCards;
                    if (handCards.Count < 7)
                    {
                        for (int i = handCards.Count; i < 7; i++)
                        {
                            if (America.Instance.CardPile.Count != 0)
                            {
                                handCards.Add(America.Instance.CardPile[0]);
                                America.Instance.CardPile.RemoveAt(0);
                            }
                        }
                    }
                }
                break;
            case "Soviet":
                {
                    handCards = Soviet.Instance.HandCards;
                    if (handCards.Count < 7)
                    {
                        for (int i = handCards.Count; i < 7; i++)
                        {
                            if (Soviet.Instance.CardPile.Count != 0)
                            {
                                handCards.Add(Soviet.Instance.CardPile[0]);
                                Soviet.Instance.CardPile.RemoveAt(0);
                            }
                        }
                    }
                }
                break;
            case "UnitedKingdom":
                {
                    handCards = UnitedKingdom.Instance.HandCards;
                    if (handCards.Count < 7)
                    {
                        for (int i = handCards.Count; i < 7; i++)
                        {
                            if (UnitedKingdom.Instance.CardPile.Count != 0)
                            {
                                handCards.Add(UnitedKingdom.Instance.CardPile[0]);
                                UnitedKingdom.Instance.CardPile.RemoveAt(0);
                            }
                        }
                    }
                }
                break;
            case "Germany":
                {
                    handCards = Germany.Instance.HandCards;
                    if (handCards.Count < 7)
                    {
                        for (int i = handCards.Count; i < 7; i++)
                        {
                            if (Germany.Instance.CardPile.Count != 0)
                            {
                                handCards.Add(Germany.Instance.CardPile[0]);
                                Germany.Instance.CardPile.RemoveAt(0);
                            }
                        }
                    }
                }
                break;
            case "Japan":
                {
                    handCards = Japan.Instance.HandCards;
                    if (handCards.Count < 7)
                    {
                        for (int i = handCards.Count; i < 7; i++)
                        {
                            if (Japan.Instance.CardPile.Count != 0)
                            {
                                handCards.Add(Japan.Instance.CardPile[0]);
                                Japan.Instance.CardPile.RemoveAt(0);
                            }
                        }
                    }
                }
                break;
            case "Italy":
                {
                    handCards = Italy.Instance.HandCards;
                    if (handCards.Count < 7)
                    {
                        for (int i = handCards.Count; i < 7; i++)
                        {
                            if (Italy.Instance.CardPile.Count != 0)
                            {
                                handCards.Add(Italy.Instance.CardPile[0]);
                                Italy.Instance.CardPile.RemoveAt(0);
                            }
                        }
                    }
                }
                break;
            default:
                Debug.LogError("Unknown country: " + country);
                return;
        }

    }

    public Card GetCardById(int id) //根据卡牌id找到卡牌
    {
        for (int index = 0; index < cardList.Count; index++)
        {
            if (cardList[index].id == id)
            {
                return cardList[index];
            }
        }
        return null;
    }


}
