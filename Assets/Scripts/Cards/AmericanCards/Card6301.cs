using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6301 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6301;
        cardName = "����ĸ��";
        introduce = "ÿ�غ���һ�Σ����㷢��սʱ���������ƶѶ���һ���ƣ���ս�������躣��";
        type = "״̬��";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/600/6301";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
