using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1203 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1203;
        cardName = "�Ӷ�";
        introduce = "ÿ��һ֧λ��<�ն���>֮��ĵ¹�½���򺣾������1�֡�";
        type = "�¼���";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/100/1203";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
