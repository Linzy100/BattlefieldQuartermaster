using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public PlateManager plateMananger =new PlateManager();  // ����ؿ���Ϣ
    public CardManager cardManager = new CardManager();      // ��������Ϣ
    public RoundManager roundManager = new RoundManager();    // ����ǰ�غ�
    public UIManager uIManager = new UIManager();          // ����UI����
    public PlateUnitManager plateUnitManager = new PlateUnitManager();   // ����ؿ�פ��


    void Start()
    {
        // ��ʼ���������߼�
    }

    void Update()
    {
        // �����߼�
    }
}
