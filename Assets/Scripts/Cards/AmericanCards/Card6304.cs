using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6304 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 6304;
        cardName = "�״�";
        introduce = "ÿ�غ���һ�Σ������ڲ���״̬����������������ʱ:�������ƶѶ���2���ƣ��������ĺ������ᱻ�Ƴ���";
        type = "״̬��";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/600/6304";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}