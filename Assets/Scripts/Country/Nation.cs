using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Nation
{
    // 当前国家
    public string country;
    // 所属阵营
    public string camp;
    // 剩余陆军
    public int army ;
    // 剩余海军
    public int navy;
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


    // Start is called before the first frame update
    public Nation()
    {
        DiscardPile = new List<Card>(); // 初始化弃牌堆
        CardPile = new List<Card>(); // 初始化抽牌堆
        HandCards = new List<Card>(); // 初始化手牌
        StatusCards = new List<Card>(); // 初始化局势牌
        CountermeasuresCards = new List<Card>(); // 初始化对策牌
        //CardManager.Instance.InitCardPiles();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
