using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card3407 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 3407;
        cardName = "�ض���";
        introduce = "��λ��<�й�����><�й�����><������><�ɹŵ���>�Ҵ��ڲ���״̬���ձ�½�������Ƴ�ʱ����:���غϴ�½�����ᱻ�Ƴ���";
        type = "�Բ߿�";
        country = "Japan";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/300/3407";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}