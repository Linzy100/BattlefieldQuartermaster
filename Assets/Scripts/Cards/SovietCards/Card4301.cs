using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4301 : Card
{
    // Start is called before the first frame update
    public Card4301()
    {
        id = 4301;
        cardName = "���湥��";
        introduce = "ÿ�غ���һ�Σ����㷢��½ս��:������2�����ƣ���ս�������������ڵ�������½ս��";
        type = "״̬��";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/400/4301";
    }
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
