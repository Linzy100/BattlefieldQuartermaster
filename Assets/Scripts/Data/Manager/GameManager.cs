using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;  // ����ʵ��

    public PlateMananger plateMananger;  // ����ؿ���Ϣ
    public CardManager cardManager;      // ��������Ϣ
    public RoundManager roundManager;    // ����ǰ�غ�
    public UIManager uIManager;          // ����UI����
    public PlateUnitManager plateUnitManager;   // ����ؿ�פ��
    public AdjacencyMatrixManager adjacencyMatrixManager;   // �����ڽӾ���

    void Awake()
    {
        // ȷ����Ϸ�������ǵ���
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // ��֤�ö����ڳ����л�ʱ������
        }
        else
        {
            Destroy(gameObject); // ����Ѵ���һ��ʵ���������ٵ�ǰ��GameManager
        }
    }

    void Start()
    {
        // ��ʼ���������߼�
    }

    void Update()
    {
        // �����߼�
    }
}
