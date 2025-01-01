using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlateManager : Singleton<PlateManager>
{
    // Start is called before the first frame update
    public PlateData plateInfo;//存放总的地块信息
    public plateData curPlateInfo;//存放当前需要获取的地块信息
    List<plateData> platelist = new List<plateData>();
    //void Start()
    //{
    //    //plateInfo = new PlateData();
    //    curPlateInfo = new plateData();
    //    for (int i = 0; i < plateInfo.plateDatas.Count; i++)
    //    {
    //        platelist.Add(plateInfo.plateDatas[i]);
    //        Debug.Log(plateInfo.plateDatas[i].plateName);
    //    }

    //}
    void Start()
    {
        curPlateInfo = new plateData();
        platelist = new List<plateData>(new plateData[plateInfo.plateDatas.Count]); // 初始化platelist，确保大小一致
        for (int i = 0; i < plateInfo.plateDatas.Count; i++)
        {
            platelist[i] = new plateData(); // 确保每个元素都被初始化
            platelist[i].plateId = plateInfo.plateDatas[i].plateId;
            platelist[i].plateName = plateInfo.plateDatas[i].plateName;
            platelist[i].plateType = plateInfo.plateDatas[i].plateType;
            platelist[i].takeStatuByCountry1 = plateInfo.plateDatas[i].takeStatuByCountry1;
            platelist[i].takeStatuByCountry2 = plateInfo.plateDatas[i].takeStatuByCountry2;
            platelist[i].takeStatuByCountry3 = plateInfo.plateDatas[i].takeStatuByCountry3;
            platelist[i].takeStatuByCampus = plateInfo.plateDatas[i].takeStatuByCampus;
            platelist[i].isAlliesScore = plateInfo.plateDatas[i].isAlliesScore;
            platelist[i].isAlliesSupply = plateInfo.plateDatas[i].isAlliesSupply;
            platelist[i].isAxisScore = plateInfo.plateDatas[i].isAxisScore;
            platelist[i].isAxisSupply = plateInfo.plateDatas[i].isAxisSupply;
            platelist[i].isInSupply = plateInfo.plateDatas[i].isInSupply;
            //Debug.Log(plateInfo.plateDatas[i].plateName);
        }
    }

    public List<plateData> returnAllPlateInfo()
    {
        return platelist;
    }

    public plateData getCurPlateInfo(string name) //根据名字查找地块
    {
        for (int i = 0; i < platelist.Count; i++)
        {
            if (platelist[i].plateName.StartsWith(name))
            {
                curPlateInfo = platelist[i];
            }
        }
        return curPlateInfo;
    }

    public List<plateData> getPlateInfoByCountry(string countryname) //根据占领国家查找地块
    {
        List<plateData> p = new List<plateData>();
        for (int i = 0; i < platelist.Count; i++)
        {
            if (platelist[i].takeStatuByCountry1.Equals(countryname) || platelist[i].takeStatuByCountry2.Equals(countryname) || platelist[i].takeStatuByCountry3.Equals(countryname))
            {
                p.Add(platelist[i]);
            }
        }
        return p;
    }

    public void changePlateSupplyStatus(plateData plate, int type)//修改补给状态，0改为未补给，1改为处于补给
    {
        if (type == 0)
        {
            plate.isInSupply = false;
        }
        else if (type == 1)
        {
            plate.isInSupply = true;
        }
    }

    public void changeOccupiedCountry(string changedPlateName, string country) //组建军队
    {

        for (int i = 0; i < platelist.Count; i++)
        {
            if (platelist[i].plateName.StartsWith(changedPlateName))
            {
                if (platelist[i].takeStatuByCountry1 == "")
                {
                    platelist[i].takeStatuByCountry1 = country;
                }
                else if (platelist[i].takeStatuByCountry2 == "")
                {
                    platelist[i].takeStatuByCountry2 = country;
                }
                else if (platelist[i].takeStatuByCountry3 == "")
                {
                    platelist[i].takeStatuByCountry3 = country;
                }
            }
        }
    }

    public void attackOccupiedCountry(string changedPlateName, string country) //攻击占领国家,某个地区的占领军队减少特定的一支（海战陆战）
    {
        for (int i = 0; i < platelist.Count; i++)
        {
            if (platelist[i].plateName.StartsWith(changedPlateName))
            {
                if (platelist[i].takeStatuByCountry1 == country)
                {
                    platelist[i].takeStatuByCountry1 = null;
                }
                else if (platelist[i].takeStatuByCountry2 == country)
                {
                    platelist[i].takeStatuByCountry2 = null;
                }
                else if (platelist[i].takeStatuByCountry3 == country)
                {
                    platelist[i].takeStatuByCountry3 = null;
                }
            }
        }
    }

    public void changeOccupiedCamp(string changedPlateName, string camp) //修改占领阵营
    {
        for (int i = 0; i < platelist.Count; i++)
        {
            if (platelist[i].plateName.Contains(changedPlateName))
            {
                platelist[i].takeStatuByCampus = camp;
            }
        }
    }

    public void changeScoretoAxis(string changedPlateName)//修改某个地区对轴心国而言的得分状态
    {

    }

    public void changeScoretoAllies(string changedPlateName)//修改某个地区对轴心国而言的得分状态
    {

    }
}
