using System.Collections.Generic;
using UnityEngine;

public class AdjacencyMatrix : Singleton<AdjacencyMatrix>
{
    // ��������
    private const int N = 51;

    // ��һ�ڽӾ���
    private int[,] adjacencyMatrix = new int[N, N];

    // ������ӳ��
    private Dictionary<string, int> regionMap = new Dictionary<string, int>
    {
        {"���ô�", 0}, {"����", 1}, {"����̫ƽ��", 2}, {"��������", 3}, {"��������", 4},
        {"����", 5}, {"���е�Ⱥ��", 6}, {"����", 7}, {"�д�����", 8}, {"�ϴ�����", 9},
        {"��ŷ", 10}, {"���ޱ���", 11}, {"�����ϲ�", 12}, {"˹������ά��", 13}, {"���޵ĺ�", 14},
        {"�ն���", 15}, {"�����", 16}, {"���к�", 17}, {"��˹����", 18}, {"��ŷ", 19},
        {"�ڿ���", 20}, {"Ī˹��", 21}, {"�Ͷ���", 22}, {"�ں�", 23}, {"�ж�", 24},
        {"��������", 25}, {"����˹��", 26}, {"ӡ����", 27}, {"��������", 28}, {"������˹̹", 29},
        {"�ɹŵ���", 30}, {"�й�����", 31}, {"�й�����", 32}, {"ӡ��", 33}, {"������", 34},
        {"ӡ��������", 35}, {"������", 36}, {"�ձ�", 37}, {"����", 38}, {"���ɱ�", 39},
        {"�Ϻ�", 40}, {"�¼�����", 41}, {"�Ĵ�����", 42}, {"��̫ƽ��", 43}, {"������", 44},
        {"��ǵ�", 45}, {"��̫ƽ��", 46}, {"��̫ƽ��", 47}, {"������", 48}, {"��̫ƽ��", 49},{"�ﺣ",50}
    };

    // �ڽӹ�ϵ
    private Dictionary<string, object> relationships = new Dictionary<string, object>
    {
        {"���ô�", new List<string> {"����", "��������", "��̫ƽ��"}},
        {"����", new List<string> {"���ô�", "��������", "����̫ƽ��", "��̫ƽ��", "��������"}},
        {"����̫ƽ��", new Dictionary<string, List<string>>
            {
                {"ͬ�˹�", new List<string> {"��������", "�ϴ�����", "����", "��̫ƽ��", "��������"}},
                {"���Ĺ�", new List<string> {"��������", "�ϴ�����", "����", "��̫ƽ��"}}
            }
        },
        {"��������", new Dictionary<string, List<string>>
            {
                {"ͬ�˹�", new List<string> {"���ô�", "����", "��������", "����", "����", "�д�����", "����̫ƽ��"}},
                {"���Ĺ�", new List<string> {"���ô�", "����", "��������", "����", "����", "�д�����"}}
            }
        },
        {"��������", new List<string> {"����̫ƽ��", "��������", "�д�����", "�ϴ�����", "����"}},
        {"����", new List<string> {"��������", "����"}},
        {"���е�Ⱥ��", new List<string> {"����"}},
        {"����", new Dictionary<string, List<string>>
            {
                {"ͬ�˹�", new List<string> {"��������", "����", "���е�Ⱥ��", "˹������ά��", "���ޱ���", "���к�"}},
                {"���Ĺ�", new List<string> {"��������", "����", "���е�Ⱥ��", "˹������ά��", "���޵ĺ�", "���ޱ���"}}
            }
        },
        {"�д�����", new List<string> {"��������", "�ϴ�����", "�����ϲ�", "����"}},
        {"�ϴ�����", new List<string> {"����̫ƽ��", "��������", "�д�����", "�����ϲ�", "ӡ����"}},
        {"��ŷ", new List<string> {"����", "���к�", "�����", "�ն���", "���޵ĺ�"}},
        {"���ޱ���", new List<string> {"�����ϲ�", "���к�", "��������", "�ж�", "����"}},
        {"�����ϲ�", new List<string> {"�д�����", "�ϴ�����", "ӡ����", "��������", "���ޱ���"}},
        {"˹������ά��", new List<string> {"��˹����", "���޵ĺ�", "����"}},
        {"���޵ĺ�", new Dictionary<string, List<string>>
            {
                {"ͬ�˹�", new List<string> {"˹������ά��", "��˹����", "��ŷ", "�ն���", "��ŷ"}},
                {"���Ĺ�", new List<string> {"˹������ά��", "��˹����", "��ŷ", "�ն���", "��ŷ", "����"}}
            }
        },
        {"�ն���", new List<string> {"��ŷ", "��ŷ", "���޵ĺ�", "�����", "�Ͷ���"}},
        {"�����", new List<string> {"��ŷ", "�ն���", "�Ͷ���", "���к�"}},
        {"���к�", new Dictionary<string, List<string>>
            {
                {"ͬ�˹�", new List<string> {"�����", "���ޱ���", "�ж�", "�Ͷ���", "��������", "����"}},
                {"���Ĺ�", new List<string> {"�����", "���ޱ���", "�ж�", "�Ͷ���"}}
            }
        },
        {"��˹����", new List<string> {"˹������ά��", "���޵ĺ�", "��ŷ", "�ڿ���", "Ī˹��", "��������"}},
        {"��ŷ", new List<string> {"���޵ĺ�", "��˹����", "�ڿ���", "�Ͷ���", "�ն���"}},
        {"�ڿ���", new List<string> {"��˹����", "Ī˹��", "������˹̹", "�ﺣ", "�ж�", "�ں�", "�Ͷ���", "��ŷ"}},
        {"Ī˹��", new List<string> {"��˹����", "��������", "������˹̹", "�ڿ���"}},
        {"�Ͷ���", new List<string> {"�ն���", "��ŷ", "�ڿ���", "�ں�", "���к�", "�����"}},
        {"�ں�", new List<string> {"�Ͷ���", "�ڿ���", "�ж�"}},
        {"�ж�", new List<string> {"���к�", "�ں�", "�ڿ���", "�ﺣ", "������˹̹", "ӡ��", "��������", "���ޱ���"}},
        {"��������", new Dictionary<string, List<string>>
            {
                {"ͬ�˹�", new List<string> {"�ж�", "ӡ��", "������", "ӡ��������", "ӡ����", "����˹��", "���ޱ���", "�����ϲ�", "���к�", "�Ϻ�"}},
                {"���Ĺ�", new List<string> {"�ж�", "ӡ��", "������", "ӡ��������", "ӡ����", "����˹��", "���ޱ���", "�����ϲ�"}}
            }
        },
        {"����˹��", new List<string> {"��������", "ӡ����"}},
        {"ӡ����", new List<string> {"��������", "�Ĵ�����", "ӡ��������", "�Ϻ�", "�����ϲ�", "�ϴ�����", "����˹��"}},
        {"��������", new List<string> {"��˹����", "Ī˹��", "������˹̹", "�ɹŵ���", "������"}},
        {"������˹̹", new List<string> {"Ī˹��", "��������", "�ɹŵ���", "�й�����", "�ж�", "�ڿ���", "�ﺣ"}},
        {"�ɹŵ���", new List<string> {"��������", "������", "�й�����", "�й�����", "������˹̹"}},
        {"�й�����", new List<string> {"������˹̹", "�ɹŵ���", "�й�����", "������", "ӡ��"}},
        {"�й�����", new List<string> {"�ɹŵ���", "�й�����", "������", "�Ϻ�", "����", "������"}},
        {"ӡ��", new List<string> {"�й�����", "������", "��������", "�ж�"}},
        {"������", new List<string> {"��������", "�Ϻ�", "�й�����", "�й�����", "ӡ��"}},
        {"ӡ��������", new List<string> {"��������", "�Ϻ�", "ӡ����"}},
        {"������", new List<string> {"��̫ƽ��", "����", "�й�����", "�ɹŵ���", "��������"}},
        {"�ձ�", new List<string> {"����"}},
        {"����", new List<string> {"�ձ�", "��ǵ�", "��̫ƽ��", "��̫ƽ��", "���ɱ�", "�Ϻ�", "�й�����", "������"}},
            {"���ɱ�", new List<string> {"����", "��̫ƽ��", "�Ϻ�"}},
            {"�Ϻ�", new Dictionary<string, List<string>>
                {
                    {"ͬ�˹�", new List<string> {"������", "����", "���ɱ�", "��̫ƽ��", "�¼�����", "�Ĵ�����", "ӡ��������", "��������", "��̫ƽ��", "ӡ����"}},
                    {"���Ĺ�", new List<string> {"������", "����", "���ɱ�", "��̫ƽ��", "�¼�����", "�Ĵ�����", "ӡ��������", "��̫ƽ��", "ӡ����"}}
                }
            },
        {"�¼�����", new List<string> {"�Ϻ�", "��̫ƽ��", "��̫ƽ��"}},
        {"�Ĵ�����", new List<string> {"ӡ����", "�Ϻ�", "��̫ƽ��"}},
        {"��̫ƽ��", new List<string> {"������", "���ô�", "��̫ƽ��", "������", "��̫ƽ��", "��ǵ�", "����"}},
        {"������", new List<string> {"��̫ƽ��", "��̫ƽ��", "��̫ƽ��"}},
        {"��ǵ�", new List<string> {"����", "��̫ƽ��", "��̫ƽ��"}},
        {"��̫ƽ��", new List<string> {"���ɱ�", "����", "��ǵ�", "��̫ƽ��", "������", "��̫ƽ��", "��̫ƽ��", "�¼�����"}},
        {"��̫ƽ��", new List<string> {"�¼�����", "��̫ƽ��", "��̫ƽ��", "������", "�Ĵ�����", "ӡ����"}},
        {"������", new List<string> {"��̫ƽ��", "��̫ƽ��"}},
        {  "��̫ƽ��", new List<string> {"������", "������", "��̫ƽ��", "��̫ƽ��", "��̫ƽ��", "����", "���ô�"}},
        {"�ﺣ", new List<string> {"�ڿ���", "������˹̹", "�ж�"}}
    };

    // ��ʼ���ڽӾ���
    public void InitializeMatrix()
    {
        FillMatrix();
        Debug.Log("�ڽӾ����ѳ�ʼ��");
    }

    // ����ڽӾ���
    public void FillMatrix()
    {
        foreach (var entry in relationships)
        {
            string region = entry.Key;
            object neighbors = entry.Value;

            if (neighbors is Dictionary<string, List<string>> groupNeighbors)
            {
                foreach (var group in groupNeighbors)
                {
                    int value = group.Key == "ͬ�˹�" ? 3 : 2; // ͬ�˹���3�����Ĺ���2
                    foreach (var neighbor in group.Value)
                    {
                        UpdateMatrix(region, neighbor, value);
                    }
                }
            }
            else if (neighbors is List<string> simpleNeighbors)
            {
                foreach (var neighbor in simpleNeighbors)
                {
                    UpdateMatrix(region, neighbor, 1); // Ĭ��ͬʱ��ͬ�˹������Ĺ�����
                }
            }
        }
    }

    // ���¾���ֵ
    public void UpdateMatrix(string regionA, string regionB, int value)
    {
        if (regionMap.ContainsKey(regionA) && regionMap.ContainsKey(regionB))
        {
            int i = regionMap[regionA];
            int j = regionMap[regionB];

            // ������и������ȼ���ֵ�������ǣ��������
            if (adjacencyMatrix[i, j] == 0 || adjacencyMatrix[i, j] == 1)
            {
                adjacencyMatrix[i, j] = value;
                adjacencyMatrix[j, i] = value;
            }
            else if (value == 3 && adjacencyMatrix[i, j] == 2) // ͬʱ�������
            {
                adjacencyMatrix[i, j] = 1;
                adjacencyMatrix[j, i] = 1;
            }
            else if (value == 2 && adjacencyMatrix[i, j] == 3)
            {
                adjacencyMatrix[i, j] = 1;
                adjacencyMatrix[j, i] = 1;
            }
        }
    }

    // ��ȡ��������� ID��������ָ���������ڵ����� ID �б�
    public List<int> GetAdjacentRegionIds(int regionId)
    {
        List<int> adjacentRegionIds = new List<int>();

        // ��鴫������� ID �Ƿ���Ч
        if (regionId < 0 || regionId >= N)
        {
            Debug.Log($"��Ч������ ID: {regionId}");
            return adjacentRegionIds;
        }

        // �����ڽӾ�����У��ҵ�������� ID ���ڵ�����
        for (int j = 0; j < N; j++)
        {
            if (adjacencyMatrix[regionId, j] != 0) // ����ڽӾ����ֵ��Ϊ 0����ʾ���ڽӹ�ϵ
            {
                adjacentRegionIds.Add(j);
            }
        }

        return adjacentRegionIds;
    }

    // ��ӡ�ڽӾ���
    public void PrintMatrix(string title)
    {
        Debug.Log(title);
        for (int i = 0; i < N; i++)
        {
            string row = "";
            for (int j = 0; j < N; j++)
            {
                row += adjacencyMatrix[i, j] + " ";
            }
            Debug.Log(row);
        }
    }

    // ���������Ĺ�ϵ
    public void UpdateRegionRelation(string regionA, string regionB, int value)
    {
        UpdateMatrix(regionA, regionB, value);
        Debug.Log($"�����Ѹ��£�{regionA} �� {regionB} �Ĺ�ϵֵΪ {value}");
    }

    // ���������ڽӾ���
    public int[,] GetAdjacencyMatrix()
    {
        return adjacencyMatrix;
    }


    // Unity Start ����
    void Awake()
    {
        InitializeMatrix();
    }
}
