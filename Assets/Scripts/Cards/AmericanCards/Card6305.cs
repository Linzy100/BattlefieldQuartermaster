using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card6305 : Card
{
    // Start is called before the first frame update
    public Card6305()
    {
        id = 6305;
        cardName = "����Ů��";
        introduce = "ÿ�غ���һ�Σ���������ƽ׶ο�ʼʱ���ɽ�1��2�����������ƶѵ�";
        type = "״̬��";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = true;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/600/6305";
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
