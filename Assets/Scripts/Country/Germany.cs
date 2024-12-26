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
    public List<GameObject> DiscardPile;
    // 剩余牌堆
    public List<GameObject> RemainPile;
    // 当前手牌
    public List<GameObject> HandCards;
    // 当前已挂状态牌
    public List<GameObject> StatusCards;


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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
