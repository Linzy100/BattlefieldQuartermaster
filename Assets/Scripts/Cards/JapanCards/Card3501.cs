using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card3501 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 3501;
        cardName = "ӡ���󾯱���";
        introduce = "ÿ��һ֧λ��<��������>����֮���ڵ��ձ����������2�֡�Ӣ�����������ƶѶ��� 2���ơ�";
        type = "����ս";
        country = "Japan";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/300/3501";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
