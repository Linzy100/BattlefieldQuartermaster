using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1310 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2310;
        cardName = "�ϳ�ȼ��";
        introduce = "ÿ�غ���һ�Σ����㽨��½����:�������ƶѶ���2���ƣ��ڽ���½�������ڵ�������һ֧½����";
        type = "״̬��";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/100/1310";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
