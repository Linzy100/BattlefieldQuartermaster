using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 国家枚举
public enum country
{
    none = -1,  // 没有
    Germany = 0,
    UnitedKingdom = 1,
    Japan = 2,
    Soviet = 3,
    Italy = 4,
    American = 5
}

// 单位类型枚举
public enum unitType
{
    none = -1,  // 没有
    Army = 0,   // 陆军
    Navy = 1,   // 海军
    AirForce = 2 // 空军
}

// 单位类
public class Unit
{
    public country unitOfCountry1; // 军队1的所属国家
    public unitType curunitType1;  // 军队1的类型
    public country unitOfCountry2; // 军队2的所属国家
    public unitType curunitType2;  // 军队2的类型
    public country unitOfCountry3; // 军队3的所属国家
    public unitType curunitType3;  // 军队3的类型
    public country unitOfCountry4; // 军队4的所属国家
    public unitType curunitType4;  // 军队4的类型
    public country unitOfCountry5; // 军队5的所属国家
    public unitType curunitType5;  // 军队5的类型
    public country unitOfCountry6; // 军队6的所属国家
    public unitType curunitType6;  // 军队6的类型
}

// 管理类
public class PlateUnitManager : Singleton<PlateUnitManager>
{
    GameManager gameManager;
    public List<Unit> unit = new List<Unit>(51); // 一共有51个地区

    // 初始化所有地区的军队数据
    void Start()
    {
        // 初始化unit列表，确保每个地区的军队信息都设置为未初始化
        for (int i = 0; i < 51; i++)
        {
            if( i == 1)         //美国放美国陆军
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.American,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
            else if( i == 6 )       //不列颠群岛放英国陆军
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.UnitedKingdom,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
            else if ( i == 15 )  //日耳曼放德国陆军
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.Germany,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
            else if( i == 16)   //意大利放意大利陆军
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.Italy,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
            else if (i == 21 )  //莫斯科放苏联陆军
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.Italy,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
            else if (i == 37)           //日本放日本陆军
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.Italy,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
        }
    }

    // 放置军队方法
    public void PlaceUnit(string plateName, int countryId, int unitTypeId)
    {
        // 获取当前地区的信息
        plateData p = gameManager.plateMananger.getCurPlateInfo(plateName);

        // 检查当前区域是否已经有军队
        if (unit[p.plateId].unitOfCountry1 == country.none)
        {
            unit[p.plateId].unitOfCountry1 = (country)countryId;
            unit[p.plateId].curunitType1 = (unitType)unitTypeId;
        }
        else if (unit[p.plateId].unitOfCountry2 == country.none)
        {
            unit[p.plateId].unitOfCountry2 = (country)countryId;
            unit[p.plateId].curunitType2 = (unitType)unitTypeId;
        }
        else if (unit[p.plateId].unitOfCountry3 == country.none)
        {
            unit[p.plateId].unitOfCountry3 = (country)countryId;
            unit[p.plateId].curunitType3 = (unitType)unitTypeId;
        }
        else if (unit[p.plateId].unitOfCountry4 == country.none)
        {
            unit[p.plateId].unitOfCountry4 = (country)countryId;
            unit[p.plateId].curunitType4 = (unitType)unitTypeId;
        }
        else if (unit[p.plateId].unitOfCountry5 == country.none)
        {
            unit[p.plateId].unitOfCountry5 = (country)countryId;
            unit[p.plateId].curunitType5 = (unitType)unitTypeId;
        }
        else if (unit[p.plateId].unitOfCountry6 == country.none)
        {
            unit[p.plateId].unitOfCountry6 = (country)countryId;
            unit[p.plateId].curunitType6 = (unitType)unitTypeId;
        }
        else
        {
            Debug.LogError("该地区军队已满，无法继续放置！");
        }
    }

    public void RemoveUnit(string plateName, int unitIndex)
    {
        plateData p = gameManager.plateMananger.getCurPlateInfo(plateName);
        if (p.plateId < 0 || p.plateId >= unit.Count)
        {
            Debug.LogError($"PlateId {p.plateId} 超出范围！");
            return;
        }

        Unit currentUnit = unit[p.plateId];

        switch (unitIndex)
        {
            case 1:
                currentUnit.unitOfCountry1 = country.none;
                currentUnit.curunitType1 = unitType.none;
                Debug.Log($"已移除地区 {plateName} 的军队1");
                break;
            case 2:
                currentUnit.unitOfCountry2 = country.none;
                currentUnit.curunitType2 = unitType.none;
                Debug.Log($"已移除地区 {plateName} 的军队2");
                break;
            case 3:
                currentUnit.unitOfCountry3 = country.none;
                currentUnit.curunitType3 = unitType.none;
                Debug.Log($"已移除地区 {plateName} 的军队3");
                break;
            case 4:
                currentUnit.unitOfCountry4 = country.none;
                currentUnit.curunitType4 = unitType.none;
                Debug.Log($"已移除地区 {plateName} 的军队4");
                break;
            case 5:
                currentUnit.unitOfCountry5 = country.none;
                currentUnit.curunitType5 = unitType.none;
                Debug.Log($"已移除地区 {plateName} 的军队5");
                break;
            case 6:
                currentUnit.unitOfCountry6 = country.none;
                currentUnit.curunitType6 = unitType.none;
                Debug.Log($"已移除地区 {plateName} 的军队6");
                break;
            default:
                Debug.LogError($"无效的军队编号 {unitIndex}，应为1到6！");
                break;
        }
    }
}
