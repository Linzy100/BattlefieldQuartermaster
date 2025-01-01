using System.Collections.Generic;
using UnityEngine;

public class AdjacencyMatrix : Singleton<AdjacencyMatrix>
{
    // 区域数量
    private const int N = 51;

    // 单一邻接矩阵
    private int[,] adjacencyMatrix = new int[N, N];

    // 区域编号映射
    private Dictionary<string, int> regionMap = new Dictionary<string, int>
    {
        {"加拿大", 0}, {"美国", 1}, {"东南太平洋", 2}, {"北大西洋", 3}, {"拉丁美洲", 4},
        {"冰岛", 5}, {"不列颠群岛", 6}, {"北海", 7}, {"中大西洋", 8}, {"南大西洋", 9},
        {"西欧", 10}, {"非洲北部", 11}, {"非洲南部", 12}, {"斯堪的纳维亚", 13}, {"波罗的海", 14},
        {"日耳曼", 15}, {"意大利", 16}, {"地中海", 17}, {"罗斯地区", 18}, {"东欧", 19},
        {"乌克兰", 20}, {"莫斯科", 21}, {"巴尔干", 22}, {"黑海", 23}, {"中东", 24},
        {"阿拉伯海", 25}, {"马达加斯加", 26}, {"印度洋", 27}, {"西伯利亚", 28}, {"哈萨克斯坦", 29},
        {"蒙古地区", 30}, {"中国西部", 31}, {"中国东部", 32}, {"印度", 33}, {"东南亚", 34},
        {"印度尼西亚", 35}, {"海参崴", 36}, {"日本", 37}, {"东海", 38}, {"菲律宾", 39},
        {"南海", 40}, {"新几内亚", 41}, {"澳大利亚", 42}, {"北太平洋", 43}, {"夏威夷", 44},
        {"硫磺岛", 45}, {"中太平洋", 46}, {"南太平洋", 47}, {"新西兰", 48}, {"东太平洋", 49},{"里海",50}
    };

    // 邻接关系
    private Dictionary<string, object> relationships = new Dictionary<string, object>
    {
        {"加拿大", new List<string> {"美国", "北大西洋", "北太平洋"}},
        {"美国", new List<string> {"加拿大", "北大西洋", "东南太平洋", "东太平洋", "拉丁美洲"}},
        {"东南太平洋", new Dictionary<string, List<string>>
            {
                {"同盟国", new List<string> {"拉丁美洲", "南大西洋", "美国", "东太平洋", "北大西洋"}},
                {"轴心国", new List<string> {"拉丁美洲", "南大西洋", "美国", "东太平洋"}}
            }
        },
        {"北大西洋", new Dictionary<string, List<string>>
            {
                {"同盟国", new List<string> {"加拿大", "美国", "拉丁美洲", "冰岛", "北海", "中大西洋", "东南太平洋"}},
                {"轴心国", new List<string> {"加拿大", "美国", "拉丁美洲", "冰岛", "北海", "中大西洋"}}
            }
        },
        {"拉丁美洲", new List<string> {"东南太平洋", "北大西洋", "中大西洋", "南大西洋", "美国"}},
        {"冰岛", new List<string> {"北大西洋", "北海"}},
        {"不列颠群岛", new List<string> {"北海"}},
        {"北海", new Dictionary<string, List<string>>
            {
                {"同盟国", new List<string> {"北大西洋", "冰岛", "不列颠群岛", "斯堪的纳维亚", "非洲北部", "地中海"}},
                {"轴心国", new List<string> {"北大西洋", "冰岛", "不列颠群岛", "斯堪的纳维亚", "波罗的海", "非洲北部"}}
            }
        },
        {"中大西洋", new List<string> {"拉丁美洲", "南大西洋", "非洲南部", "北海"}},
        {"南大西洋", new List<string> {"东南太平洋", "拉丁美洲", "中大西洋", "非洲南部", "印度洋"}},
        {"西欧", new List<string> {"北海", "地中海", "意大利", "日耳曼", "波罗的海"}},
        {"非洲北部", new List<string> {"非洲南部", "地中海", "阿拉伯海", "中东", "北海"}},
        {"非洲南部", new List<string> {"中大西洋", "南大西洋", "印度洋", "阿拉伯海", "非洲北部"}},
        {"斯堪的纳维亚", new List<string> {"罗斯地区", "波罗的海", "北海"}},
        {"波罗的海", new Dictionary<string, List<string>>
            {
                {"同盟国", new List<string> {"斯堪的纳维亚", "罗斯地区", "东欧", "日耳曼", "西欧"}},
                {"轴心国", new List<string> {"斯堪的纳维亚", "罗斯地区", "东欧", "日耳曼", "西欧", "北海"}}
            }
        },
        {"日耳曼", new List<string> {"西欧", "东欧", "波罗的海", "意大利", "巴尔干"}},
        {"意大利", new List<string> {"西欧", "日耳曼", "巴尔干", "地中海"}},
        {"地中海", new Dictionary<string, List<string>>
            {
                {"同盟国", new List<string> {"意大利", "非洲北部", "中东", "巴尔干", "阿拉伯海", "北海"}},
                {"轴心国", new List<string> {"意大利", "非洲北部", "中东", "巴尔干"}}
            }
        },
        {"罗斯地区", new List<string> {"斯堪的纳维亚", "波罗的海", "东欧", "乌克兰", "莫斯科", "西伯利亚"}},
        {"东欧", new List<string> {"波罗的海", "罗斯地区", "乌克兰", "巴尔干", "日耳曼"}},
        {"乌克兰", new List<string> {"罗斯地区", "莫斯科", "哈萨克斯坦", "里海", "中东", "黑海", "巴尔干", "东欧"}},
        {"莫斯科", new List<string> {"罗斯地区", "西伯利亚", "哈萨克斯坦", "乌克兰"}},
        {"巴尔干", new List<string> {"日耳曼", "东欧", "乌克兰", "黑海", "地中海", "意大利"}},
        {"黑海", new List<string> {"巴尔干", "乌克兰", "中东"}},
        {"中东", new List<string> {"地中海", "黑海", "乌克兰", "里海", "哈萨克斯坦", "印度", "阿拉伯海", "非洲北部"}},
        {"阿拉伯海", new Dictionary<string, List<string>>
            {
                {"同盟国", new List<string> {"中东", "印度", "东南亚", "印度尼西亚", "印度洋", "马达加斯加", "非洲北部", "非洲南部", "地中海", "南海"}},
                {"轴心国", new List<string> {"中东", "印度", "东南亚", "印度尼西亚", "印度洋", "马达加斯加", "非洲北部", "非洲南部"}}
            }
        },
        {"马达加斯加", new List<string> {"阿拉伯海", "印度洋"}},
        {"印度洋", new List<string> {"阿拉伯海", "澳大利亚", "印度尼西亚", "南海", "非洲南部", "南大西洋", "马达加斯加"}},
        {"西伯利亚", new List<string> {"罗斯地区", "莫斯科", "哈萨克斯坦", "蒙古地区", "海参崴"}},
        {"哈萨克斯坦", new List<string> {"莫斯科", "西伯利亚", "蒙古地区", "中国西部", "中东", "乌克兰", "里海"}},
        {"蒙古地区", new List<string> {"西伯利亚", "海参崴", "中国东部", "中国西部", "哈萨克斯坦"}},
        {"中国西部", new List<string> {"哈萨克斯坦", "蒙古地区", "中国东部", "东南亚", "印度"}},
        {"中国东部", new List<string> {"蒙古地区", "中国西部", "东南亚", "南海", "东海", "海参崴"}},
        {"印度", new List<string> {"中国西部", "东南亚", "阿拉伯海", "中东"}},
        {"东南亚", new List<string> {"阿拉伯海", "南海", "中国东部", "中国西部", "印度"}},
        {"印度尼西亚", new List<string> {"阿拉伯海", "南海", "印度洋"}},
        {"海参崴", new List<string> {"北太平洋", "东海", "中国东部", "蒙古地区", "西伯利亚"}},
        {"日本", new List<string> {"东海"}},
        {"东海", new List<string> {"日本", "硫磺岛", "北太平洋", "中太平洋", "菲律宾", "南海", "中国东部", "海参崴"}},
            {"菲律宾", new List<string> {"东海", "中太平洋", "南海"}},
            {"南海", new Dictionary<string, List<string>>
                {
                    {"同盟国", new List<string> {"东南亚", "东海", "菲律宾", "中太平洋", "新几内亚", "澳大利亚", "印度尼西亚", "阿拉伯海", "南太平洋", "印度洋"}},
                    {"轴心国", new List<string> {"东南亚", "东海", "菲律宾", "中太平洋", "新几内亚", "澳大利亚", "印度尼西亚", "南太平洋", "印度洋"}}
                }
            },
        {"新几内亚", new List<string> {"南海", "中太平洋", "南太平洋"}},
        {"澳大利亚", new List<string> {"印度洋", "南海", "南太平洋"}},
        {"北太平洋", new List<string> {"海参崴", "加拿大", "东太平洋", "夏威夷", "中太平洋", "硫磺岛", "东海"}},
        {"夏威夷", new List<string> {"北太平洋", "东太平洋", "中太平洋"}},
        {"硫磺岛", new List<string> {"东海", "北太平洋", "中太平洋"}},
        {"中太平洋", new List<string> {"菲律宾", "东海", "硫磺岛", "北太平洋", "夏威夷", "东太平洋", "南太平洋", "新几内亚"}},
        {"南太平洋", new List<string> {"新几内亚", "中太平洋", "东太平洋", "新西兰", "澳大利亚", "印度洋"}},
        {"新西兰", new List<string> {"南太平洋", "东太平洋"}},
        {  "东太平洋", new List<string> {"夏威夷", "新西兰", "南太平洋", "中太平洋", "北太平洋", "美国", "加拿大"}},
        {"里海", new List<string> {"乌克兰", "哈萨克斯坦", "中东"}}
    };

    // 初始化邻接矩阵
    public void InitializeMatrix()
    {
        FillMatrix();
        Debug.Log("邻接矩阵已初始化");
    }

    // 填充邻接矩阵
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
                    int value = group.Key == "同盟国" ? 3 : 2; // 同盟国用3，轴心国用2
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
                    UpdateMatrix(region, neighbor, 1); // 默认同时与同盟国和轴心国相邻
                }
            }
        }
    }

    // 更新矩阵值
    public void UpdateMatrix(string regionA, string regionB, int value)
    {
        if (regionMap.ContainsKey(regionA) && regionMap.ContainsKey(regionB))
        {
            int i = regionMap[regionA];
            int j = regionMap[regionB];

            // 如果已有更高优先级的值，不覆盖；否则更新
            if (adjacencyMatrix[i, j] == 0 || adjacencyMatrix[i, j] == 1)
            {
                adjacencyMatrix[i, j] = value;
                adjacencyMatrix[j, i] = value;
            }
            else if (value == 3 && adjacencyMatrix[i, j] == 2) // 同时相邻情况
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

    // 获取相邻区域的 ID（返回与指定区域相邻的区域 ID 列表）
    public List<int> GetAdjacentRegionIds(int regionId)
    {
        List<int> adjacentRegionIds = new List<int>();

        // 检查传入的区域 ID 是否有效
        if (regionId < 0 || regionId >= N)
        {
            Debug.Log($"无效的区域 ID: {regionId}");
            return adjacentRegionIds;
        }

        // 遍历邻接矩阵的行，找到与该区域 ID 相邻的区域
        for (int j = 0; j < N; j++)
        {
            if (adjacencyMatrix[regionId, j] != 0) // 如果邻接矩阵的值不为 0，表示有邻接关系
            {
                adjacentRegionIds.Add(j);
            }
        }

        return adjacentRegionIds;
    }

    // 打印邻接矩阵
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

    // 更新区域间的关系
    public void UpdateRegionRelation(string regionA, string regionB, int value)
    {
        UpdateMatrix(regionA, regionB, value);
        Debug.Log($"矩阵已更新：{regionA} 与 {regionB} 的关系值为 {value}");
    }

    // 返回整个邻接矩阵
    public int[,] GetAdjacencyMatrix()
    {
        return adjacencyMatrix;
    }


    // Unity Start 方法
    void Awake()
    {
        InitializeMatrix();
    }
}
