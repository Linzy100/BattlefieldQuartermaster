using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1501 : Card
{
    // Start is called before the first frame update
    public Card1501()
    {
        id = 1501;
        cardName = "Ǳͧ��ǿ�з���";
        introduce = "ÿ��һ֧��<����>���ڵĵ¹�½���򺣾������1�֡�Ӣ�����������ƶѶ���2 ���ơ�";
        type = "����ս";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/100/1501";
    }
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
