using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2305 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2305;
        cardName = "Ӣ���ʼҺ���";
        introduce = "ÿ�غ���һ�Σ����㷢��սʱ:������2�����ƣ��ڷ���ս�ĺ������һ��������ս";
        type = "״̬��";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/200/2305";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
