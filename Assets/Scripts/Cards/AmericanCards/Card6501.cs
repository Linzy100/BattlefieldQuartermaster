using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6501 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6501;
        cardName = "B-24 �����";
        introduce = "������<�����>�����������ڴ�������½����������������ƶѶ���4����";
        type = "����ս";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/600/6501";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
