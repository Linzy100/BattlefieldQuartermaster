using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card5501 : Card
{
    // Start is called before the first frame update
    public Card5501()
    {
        id = 5501;
        cardName = "��ʮ���𽢽���";
        introduce = "������<�����>�����������ڴ�������½����������������ƶѶ���4����Ӣ�����������ƶѶ���1���ƣ���<���к�>û��ͬ�˹��ĺ������Ϊ2�š���������1�֡�";
        type = "����ս";
        country = "Italian";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/500/5501";
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
