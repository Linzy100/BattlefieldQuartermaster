using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card5205 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 5205;
        cardName = "������������";
        introduce = "��<�ڿ���>����½��;��<��˹����>����½����";
        type = "�¼���";
        country = "Italian";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/500/5205";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
