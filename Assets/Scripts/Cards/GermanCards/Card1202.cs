using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1202 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1202;
        cardName = "�Ͷ��ɾ�������";
        introduce = "��<�Ͷ���>����һ֧�����½��;��<�ڿ���>����һ֧ͬ�˹�½��";
        type = "�¼���";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/100/1202";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}