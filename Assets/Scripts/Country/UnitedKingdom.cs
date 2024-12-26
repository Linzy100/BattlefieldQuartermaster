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
    public List<GameObject> DiscardPile;
    // 剩余牌堆
    public List<GameObject> RemainPile;
    // 当前手牌
    public List<GameObject> HandCards;
    // 当前已挂状态牌
    public List<GameObject> StatusCards;
    //当前已挂对策牌
    public List<GameObject> CountermeasuresCards;


    // Start is called before the first frame update
    void start()
    {
        DiscardPile = new List<GameObject>(); // 初始化弃牌堆
        // 初始化剩余牌堆
        RemainPile = new List<GameObject>();
        // 此时剩余牌堆应该是所有牌的集合
        // 添加所有牌
        // 这里你需要根据你的游戏逻辑来添加卡牌到RemainPile

        HandCards = new List<GameObject>(); // 初始化手牌
        StatusCards = new List<GameObject>(); // 初始化局势牌
        CountermeasuresCards = new List<GameObject>();// 初始化对策牌
    }

    // Update is called once per frame
    void Update()
    {

    }
}
