using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4405 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 4405;
        cardName = "ʪ������";
        introduce = "�����Ĺ���<Ī˹��>�������ڵ�������½��ʱ����:���������佨���½��";
        type = "�Բ߿�";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/400/4405";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}