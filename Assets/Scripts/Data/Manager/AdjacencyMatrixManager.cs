using System.Collections.Generic;
using UnityEngine;

public class AdjacencyMatrixManager : MonoBehaviour
{
    private AdjacencyMatrix adjacencyMatrix;  // 存储邻接矩阵实例

    // 区域数量常量
    private const int N = 51;

    // 构造函数
    public AdjacencyMatrixManager()
    {
        adjacencyMatrix = new AdjacencyMatrix();
    }

    // 初始化邻接矩阵
    public void InitializeMatrix()
    {
        // 填充邻接矩阵
        adjacencyMatrix.FillMatrix();
        Debug.Log("邻接矩阵已初始化");
    }

    // 更新矩阵值（手动更新两个区域间的关系）
    public void UpdateRegionRelation(string regionA, string regionB, int value)
    {
        adjacencyMatrix.UpdateMatrix(regionA, regionB, value);
        Debug.Log($"矩阵已更新：{regionA} 与 {regionB} 的关系值为 {value}");
    }

    // 获取相邻区域的 ID（返回与指定区域相邻的区域 ID 列表）
    public List<int> GetAdjacentRegionIds(int regionId)
    {
        List<int> adjacentRegionIds = new List<int>();

        // 检查传入的区域 ID 是否有效
        if (regionId < 0 || regionId >= N)
        {
            Debug.LogWarning($"无效的区域 ID: {regionId}");
            return adjacentRegionIds;
        }

        // 遍历邻接矩阵的行，找到与该区域 ID 相邻的区域
        for (int j = 0; j < N; j++)
        {
            if (adjacencyMatrix.GetMatrix()[regionId, j] != 0) // 如果邻接矩阵的值不为 0，表示有邻接关系
            {
                adjacentRegionIds.Add(j);
            }
        }

        return adjacentRegionIds;
    }

    // 打印邻接矩阵
    public void PrintMatrix()
    {
        adjacencyMatrix.PrintMatrix(adjacencyMatrix.GetMatrix(), "邻接矩阵");
    }
}
