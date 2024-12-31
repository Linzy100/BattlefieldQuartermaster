using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchOperation : MonoBehaviour    // 搜寻目标
{
    // 定义单例实例
    private static SearchOperation _instance;

    // 确保实例是线程安全的
    public static SearchOperation Instance
    {
        get
        {
            if (_instance == null)
            {
                // 通过查找场景中已经挂载的对象来获取唯一实例
                _instance = FindObjectOfType<SearchOperation>();
                if (_instance == null)
                {
                    // 如果没有找到实例，动态创建一个新的 GameObject 并挂载 SearchOperation 脚本
                    GameObject singletonObj = new GameObject("SearchOperation");
                    _instance = singletonObj.AddComponent<SearchOperation>();
                }
            }
            return _instance;
        }
    }

    // 保证构造函数是私有的，外部无法直接创建实例
    private SearchOperation() { }

    private const int N = 51;
    private int[,] adjacencyMatrix = new int[N, N]; // 矩阵
    private Dictionary<string, int> regionMap = new Dictionary<string, int>()
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
    List<plateData> plates; // 所有的板块信息

    // 查找可以设置陆军的板块
    public List<plateData> SearchSetArmy(string nationName, List<plateData> plates, string campusName)
    {
        List<plateData> isSetArmy = new List<plateData>(); // 可创建的陆军
        List<int> searchById = new List<int>(); // 存放的要查找后的板块id
        isSetArmy = SearchMethod(searchById, nationName, campusName);
        canSetPlate(isSetArmy, searchById,campusName);
        foreach (plateData plate in isSetArmy)
        {
            if (!plate.plateType.Equals("陆地"))
            {
                isSetArmy.Remove(plate);
            }
        }
        return isSetArmy;
    }

    // 陆地攻击判断
    public List<plateData> SearchAttackArmy(string nationName, string campusName)
    {
        List<plateData> isAttackedArmy = new List<plateData>(); // 可被攻击的陆军
        List<int> searchById = new List<int>(); // 存放的要查找后的板块id
        isAttackedArmy = SearchMethod(searchById, nationName, campusName);
        canAttackPlate(isAttackedArmy, searchById,campusName);
        foreach (plateData plate in isAttackedArmy)
        {
            if (!plate.plateType.Equals("陆地"))
            {
                isAttackedArmy.Remove(plate);
            }
        }
        return isAttackedArmy;
    }

    // 创建海军
    public List<plateData> SearchSetNavy(string nationName,List<plateData> plates, string campusName)
    {
        List<plateData> isSetNavy = new List<plateData>(); // 可创建的海军
        List<int> searchById = new List<int>(); // 存放的要查找后的板块id
        isSetNavy = SearchMethod(searchById, nationName, campusName);
        canSetPlate(isSetNavy, searchById,campusName);
        foreach (plateData plate in isSetNavy)
        {
            if (!plate.plateType.Equals("海洋"))
            {
                isSetNavy.Remove(plate);
            }
        }
        return isSetNavy;
    }

    // 海洋攻击判断
    public List<plateData> SearchAttackNavy(string nationName, string campusName)
    {
        List<plateData> isAttackedNavy = new List<plateData>(); // 可被攻击的海军
        List<int> searchById = new List<int>(); // 存放的要查找后的板块id
        isAttackedNavy = SearchMethod(searchById, nationName, campusName);
        canAttackPlate(isAttackedNavy, searchById,campusName);
        foreach (plateData plate in isAttackedNavy)
        {
            if (!plate.plateType.Equals("海洋"))
            {
                isAttackedNavy.Remove(plate);
            }
        }
        return isAttackedNavy;
    }

    public List<plateData> SearchMethod(List<int> searchById,string nationName, string campusName)
    {
        List<plateData> returnList = new List<plateData>();
        List<int> temp = new List<int>();

        // 查找所属国家占领的地块且属于补给状态，存放他们的编号，后续进行搜索
        foreach (plateData plate in plates)
        {
            if (GameManager.Instance.plateMananger.Equals(nationName) && plate.isInSupply == true)
            {
                if (!temp.Contains(plate.plateId)) // 避免重复存放
                    temp.Add(plate.plateId);
            }
        }

        // 在邻接矩阵查找
        foreach (int id in temp)
        {
            foreach (int index in GetNeighborsById(id,campusName))
            {
                if (!searchById.Contains(index))
                    searchById.Add(index);
            }
        }

        // 除去已经是补给点的情况
        foreach (int id in temp)
        {
            if (searchById.Contains(id))
                searchById.Remove(id);
        }

        // 返回的是符合条件的相邻板块
        return returnList;
    }

    private void canSetPlate(List<plateData> returnList, List<int> searchById, string campusName)
    {
        foreach (int id in searchById)
        {
            foreach (plateData plate in plates)
            {
                if (plate.plateId == id && (plate.takeStatuByCampus.Equals(campusName) || plate.takeStatuByCampus == null))
                {
                    returnList.Add(plate);
                    break;
                }
            }
        }
    }

    private void canAttackPlate(List<plateData> returnList, List<int> searchById,string campusName)
    {
        foreach (int id in searchById)
        {
            foreach (plateData plate in plates)
            {
                if (plate.plateId == id && !(plate.takeStatuByCampus.Equals(campusName) || plate.takeStatuByCampus == null))
                {
                    returnList.Add(plate);
                    break;
                }
            }
        }
    }

    public List<int> GetNeighborsById(int id,string campusName)
    {
        List<int> neighbors = new List<int>();
        if (id >= 0 && id < N)
        {
            // 遍历邻接矩阵的该行
            for (int j = 0; j < N; j++)
            {
                if (adjacencyMatrix[id, j] == 1)
                    neighbors.Add(j);
                if (campusName.Equals("Axis") && adjacencyMatrix[id, j] == 2)
                    neighbors.Add(j);
                else if (campusName.Equals("Allies") && adjacencyMatrix[id, j] == 3)
                    neighbors.Add(j);
            }
        }
        return neighbors;
    }
}
