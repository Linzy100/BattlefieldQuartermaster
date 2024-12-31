using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;  // 单例实例

    public PlateMananger plateMananger;  // 管理地块信息
    public CardManager cardManager;      // 管理卡牌信息
    public RoundManager roundManager;    // 管理当前回合
    public UIManager uIManager;          // 管理UI交互
    public PlateUnitManager plateUnitManager;   // 管理地块驻军
    public AdjacencyMatrixManager adjacencyMatrixManager;   // 管理邻接矩阵

    void Awake()
    {
        // 确保游戏管理器是单例
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 保证该对象在场景切换时不销毁
        }
        else
        {
            Destroy(gameObject); // 如果已存在一个实例，则销毁当前的GameManager
        }
    }

    void Start()
    {
        // 初始化或其他逻辑
    }

    void Update()
    {
        // 更新逻辑
    }
}
