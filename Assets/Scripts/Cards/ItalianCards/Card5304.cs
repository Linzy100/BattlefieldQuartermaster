using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card5304 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 5304;
        cardName = "�����ֳ��ص۹�";
        introduce = "����ļƷֽ׶�:<���ޱ���><�����ϲ�><�ж�>����ÿ��һ�����������Ĺ�ռ�죬���1�֡�";
        type = "״̬��";
        country = "Italian";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = true;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/500/5304";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}