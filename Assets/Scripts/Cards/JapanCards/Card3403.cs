using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card3403 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 3403;
        cardName = "ȫ���ֻ�";
        introduce = "������<�й�����>�������ڵ�������½սʱ����:��ս����������½��;��<�й�����>�������ڵ�������½ս��";
        type = "�Բ߿�";
        country = "Japan";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/300/3403";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}