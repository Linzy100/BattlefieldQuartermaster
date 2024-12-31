using System.Collections.Generic;
using UnityEngine;

public class AdjacencyMatrixManager : MonoBehaviour
{
    private AdjacencyMatrix adjacencyMatrix;  // �洢�ڽӾ���ʵ��

    // ������������
    private const int N = 51;

    // ���캯��
    public AdjacencyMatrixManager()
    {
        adjacencyMatrix = new AdjacencyMatrix();
    }

    // ��ʼ���ڽӾ���
    public void InitializeMatrix()
    {
        // ����ڽӾ���
        adjacencyMatrix.FillMatrix();
        Debug.Log("�ڽӾ����ѳ�ʼ��");
    }

    // ���¾���ֵ���ֶ��������������Ĺ�ϵ��
    public void UpdateRegionRelation(string regionA, string regionB, int value)
    {
        adjacencyMatrix.UpdateMatrix(regionA, regionB, value);
        Debug.Log($"�����Ѹ��£�{regionA} �� {regionB} �Ĺ�ϵֵΪ {value}");
    }

    // ��ȡ��������� ID��������ָ���������ڵ����� ID �б�
    public List<int> GetAdjacentRegionIds(int regionId)
    {
        List<int> adjacentRegionIds = new List<int>();

        // ��鴫������� ID �Ƿ���Ч
        if (regionId < 0 || regionId >= N)
        {
            Debug.LogWarning($"��Ч������ ID: {regionId}");
            return adjacentRegionIds;
        }

        // �����ڽӾ�����У��ҵ�������� ID ���ڵ�����
        for (int j = 0; j < N; j++)
        {
            if (adjacencyMatrix.GetMatrix()[regionId, j] != 0) // ����ڽӾ����ֵ��Ϊ 0����ʾ���ڽӹ�ϵ
            {
                adjacentRegionIds.Add(j);
            }
        }

        return adjacentRegionIds;
    }

    // ��ӡ�ڽӾ���
    public void PrintMatrix()
    {
        adjacencyMatrix.PrintMatrix(adjacencyMatrix.GetMatrix(), "�ڽӾ���");
    }
}
