using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1502 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1502;
        cardName = "Ǳͧ������������ս";
        introduce = "ÿ��һ֧�ڰ�ͼ�ϵĵ¹����������1�֡�Ӣ�����������ƶѶ���2���ơ�";
        type = "����ս";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/100/1502";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
