using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card5502 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 5502;
        cardName = "�ʼҺ���������·";
        introduce = "ÿ��һ֧�ڰ�ͼ�ϵ���������������1�֡�Ӣ�����������ƶѶ���1���ơ�";
        type = "����ս";
        country = "Italian";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/500/5502";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
