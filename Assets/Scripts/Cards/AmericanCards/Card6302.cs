using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6302 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6302;
        cardName = "��¼��ս";
        introduce = "ÿ�غ���һ�Σ����㷢��½սʱ:��ս�������ڽӴ��ڲ���״̬��������������������ƶѶ���1���ƣ��ڸõ�������½����";
        type = "״̬��";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
