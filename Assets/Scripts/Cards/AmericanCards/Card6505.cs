using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6505 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6505;
        cardName = "SBD ��ηʽ�����ը��";
        introduce = "������<�ձ�>�����������ڴ��������������ձ��������ƶѶ���4����";
        type = "����ս";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/600/6505";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
