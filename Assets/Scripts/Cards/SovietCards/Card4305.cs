using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4305 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 4305;
        cardName = "����ɯ";
        introduce = "ÿ�غ���һ�Σ��㷢��½ս��:������1�����ƣ�����ͬ�ĵ�������½ս��";
        type = "״̬��";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/400/4305";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
