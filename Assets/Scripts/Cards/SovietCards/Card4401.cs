using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4401 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 4401;
        cardName = "�������";
        introduce = "����ĻغϿ�ʼʱ����:��<Ī˹��>�������ڵ�������½��;��<Ī˹��>����һ֧���Ĺ�½����";
        type = "�Բ߿�";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/400/4401";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
