using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6204 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6204;
        cardName = "�ϴ￨�ɶ���";
        introduce = "��<������>����½��;��<������>���ں������ٺ���";
        type = "�¼���";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/600/6204";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
