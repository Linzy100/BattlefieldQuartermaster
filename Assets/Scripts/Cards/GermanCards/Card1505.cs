using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1505 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1505;
        cardName = "V2���ɵ�";
        introduce = "���е¹�½��λ��<��ŷ>�����3�֡�Ӣ�����������ƶѶ���1���ơ�";
        type = "����ս";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/100/1505";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
