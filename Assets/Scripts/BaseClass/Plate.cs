using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Plate:MonoBehaviour//�ؿ����
{
    
    string objectName;//��ȡ���ڰ�����֣�Ϊ��������������ƥ��

    public PlateData data;//ֱ����ק

    public int plateId;//���Id
    public string plateName;//�������
    public string plateType;//�������
    public string takeStatuByCountry = null;//��ռ����������ң�
    public string takeStatuByCampus = null;//��ռ���������Ӫ��
    public bool isAlliesSupply = false;//�Ƿ�Ϊͬ�˹�������
    public bool isAxisSupply = false;//�Ƿ�Ϊ���Ĺ�������
    public bool isAlliesScore = false;//�Ƿ�Ϊͬ�˹��÷ֵ�
    public bool isAxisScore = false;//�Ƿ�Ϊ���Ĺ��÷ֵ�
    public bool isInSupply = false;//�Ƿ��ڲ���״̬

    private void Start()
    {
        objectName = this.gameObject.name;
        Debug.Log(objectName);
        //data = ScriptableObject.CreateInstance<PlateData>();
        //Debug.Log(data.plateDatas[0].plateName);
        ReadPlateTable(objectName,data);//��ȡ���
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
                    Debug.Log("δ��������");
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
