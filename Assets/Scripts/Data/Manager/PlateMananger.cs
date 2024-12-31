using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class PlateMananger :MonoBehaviour
{
    public PlateData plateInfo;//����ܵĵؿ���Ϣ
    public plateData curPlateInfo;//��ŵ�ǰ��Ҫ��ȡ�ĵؿ���Ϣ
    List<plateData> platelist = new List<plateData>();
    void Start()
    {
        
        for (int i = 0; i < plateInfo.plateDatas.Count; i++)
        {
            platelist.Add(plateInfo.plateDatas[i]);
            Debug.Log(plateInfo.plateDatas[i].plateName);
        }

    }

    void Update()
    {
        
    }

    public List<plateData> returnAllPlateInfo()
    {
        return platelist;
    }

    public plateData getCurPlateInfo(string name) //�������ֲ��ҵؿ�
    {
        for( int i = 0; i < platelist.Count; i++)
        {
            if( platelist[i].plateName.StartsWith(name))
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
            if ( platelist[i].takeStatuByCountry1.Equals(countryname) || platelist[i].takeStatuByCountry2.Equals(countryname) || platelist[i].takeStatuByCountry3.Equals(countryname))
            {
                p.Add(platelist[i]);
            }
        }
        return p;
    }

    public void changePlateSupplyStatus(plateData plate,int type)//�޸Ĳ���״̬��0��Ϊδ������1��Ϊ���ڲ���
    {
        if( type == 0 )
        {
            plate.isInSupply = false;
        }
        else if ( type == 1 )
        {
            plate.isInSupply = true;
        }
    }

    public void changeOccupiedCountry(string changedPlateName,string country) //�齨����
    {

        for (int i = 0; i < platelist.Count; i++)
        {
            if (platelist[i].plateName.StartsWith(changedPlateName))
            {
                if ( platelist[i].takeStatuByCountry1 == null )
                {
                    platelist[i].takeStatuByCountry1 = country;
                }
                else if( platelist[i].takeStatuByCountry2 == null)
                {
                    platelist[i].takeStatuByCountry2 = country;
                }
                else if( platelist[i].takeStatuByCountry3 == null)
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
