using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6504 : Card
{
    // Start is called before the first frame update
    public Card6504()
    {
        id = 6504;
        cardName = "ȼ�յ���ը";
        introduce = "������ĳ���Ĺ��Ĵ�Ӫһ���������ڴ�������½���򺣾��������Ĺ��������ƶѶ���7����";
        type = "����ս";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/600/6504";
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
