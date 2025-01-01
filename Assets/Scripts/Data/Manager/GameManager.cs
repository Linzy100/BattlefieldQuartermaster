using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public PlateManager plateMananger =new PlateManager();  // 管理地块信息
    public CardManager cardManager = new CardManager();      // 管理卡牌信息
    public RoundManager roundManager = new RoundManager();    // 管理当前回合
    public UIManager uIManager = new UIManager();          // 管理UI交互
    public PlateUnitManager plateUnitManager = new PlateUnitManager();   // 管理地块驻军


    void Start()
    {
        // 初始化或其他逻辑
    }

    void Update()
    {
        // 更新逻辑
    }
}
