using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Plate:MonoBehaviour//地块情况
{
    
    string objectName;//读取所在板块名字，为后续搜索表格进行匹配

    public PlateData data;//直接拖拽

    public int plateId;//板块Id
    public string plateName;//板块名称
    public string plateType;//板块类型
    public string takeStatuByCountry = null;//被占领情况（国家）
    public string takeStatuByCampus = null;//被占领情况（阵营）
    public bool isAlliesSupply = false;//是否为同盟国补给点
    public bool isAxisSupply = false;//是否为轴心国补给点
    public bool isAlliesScore = false;//是否为同盟国得分点
    public bool isAxisScore = false;//是否为轴心国得分点
    public bool isInSupply = false;//是否处于补给状态

    private void Start()
    {
        objectName = this.gameObject.name;
        Debug.Log(objectName);
        //data = ScriptableObject.CreateInstance<PlateData>();
        //Debug.Log(data.plateDatas[0].plateName);
        ReadPlateTable(objectName,data);//读取表格
    }

    private void Update()
    {
        
    }
    public void ReadPlateTable(string objectName,PlateData data)
    {
        if (data == null)
        {
            Debug.Log("data is null");
        }
        if(data != null)
        {
            if (data.plateDatas != null)
            {
                int flag = 0;
                foreach (plateData eachDate in data.plateDatas)
                {
                    if (objectName.StartsWith(eachDate.plateName))
                    {
                        plateId = eachDate.plateId;
                        plateName = eachDate.plateName;
                        plateType = eachDate.plateType;
                        takeStatuByCountry = eachDate.takeStatuByCountry;
                        takeStatuByCampus = eachDate.takeStatuByCampus;
                        isAlliesSupply = eachDate.isAlliesSupply;
                        isAlliesScore = eachDate.isAlliesScore;
                        isAxisScore = eachDate.isAxisSupply;
                        isAxisScore = eachDate.isAxisScore;
                        isInSupply = eachDate.isInSupply;
                        flag = 1;
                        break;
                    }
                    else if (objectName.Equals(eachDate.plateName))
                    {
                        plateId = eachDate.plateId;
                        plateName = eachDate.plateName;
                        plateType = eachDate.plateType;
                        takeStatuByCountry = eachDate.takeStatuByCountry;
                        takeStatuByCampus = eachDate.takeStatuByCampus;
                        isAlliesSupply = eachDate.isAlliesSupply;
                        isAlliesScore = eachDate.isAlliesScore;
                        isAxisScore = eachDate.isAxisSupply;
                        isAxisScore = eachDate.isAxisScore;
                        isInSupply = eachDate.isInSupply;
                        flag = 1;
                        break;
                    }
                }
                if(flag == 0)
                {
                    Debug.Log("未读到数据");
                }
                else
                {
                    Debug.Log(plateId + plateName + plateType + takeStatuByCountry + takeStatuByCampus + isAlliesSupply + isAlliesScore + isAxisSupply + isAxisScore + isInSupply);
                }
            }
            else
            {
                Debug.Log("platedata is null");
            }
        }
    }

}
