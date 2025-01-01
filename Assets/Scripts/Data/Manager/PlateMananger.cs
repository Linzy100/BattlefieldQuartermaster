using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlateManager : Singleton<PlateManager>
{
    // Start is called before the first frame update
    public PlateData plateInfo;//����ܵĵؿ���Ϣ
    public plateData curPlateInfo;//��ŵ�ǰ��Ҫ��ȡ�ĵؿ���Ϣ
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
        platelist = new List<plateData>(new plateData[plateInfo.plateDatas.Count]); // ��ʼ��platelist��ȷ����Сһ��
        for (int i = 0; i < plateInfo.plateDatas.Count; i++)
        {
            platelist[i] = new plateData(); // ȷ��ÿ��Ԫ�ض�����ʼ��
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

    public plateData getCurPlateInfo(string name) //�������ֲ��ҵؿ�
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

    public List<plateData> getPlateInfoByCountry(string countryname) //����ռ����Ҳ��ҵؿ�
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

    public void changePlateSupplyStatus(plateData plate, int type)//�޸Ĳ���״̬��0��Ϊδ������1��Ϊ���ڲ���
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

    public void changeOccupiedCountry(string changedPlateName, string country) //�齨����
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

    public void attackOccupiedCountry(string changedPlateName, string country) //����ռ�����,ĳ��������ռ����Ӽ����ض���һ֧����ս½ս��
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

    public void changeOccupiedCamp(string changedPlateName, string camp) //�޸�ռ����Ӫ
    {
        for (int i = 0; i < platelist.Count; i++)
        {
            if (platelist[i].plateName.Contains(changedPlateName))
            {
                platelist[i].takeStatuByCampus = camp;
            }
        }
    }

    public void changeScoretoAxis(string changedPlateName)//�޸�ĳ�����������Ĺ����Եĵ÷�״̬
    {

    }

    public void changeScoretoAllies(string changedPlateName)//�޸�ĳ�����������Ĺ����Եĵ÷�״̬
    {

    }
}
