using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card3411 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 3411;
        cardName = "���Ⱥ��";
        introduce = "�����ڲ���״̬�������½�����Ƴ��󴥷�:�ڸõ������ٵ¹�½����";
        type = "�Բ߿�";
        country = "Japan";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = true;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = true;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = true;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = true;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = true;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/300/3411";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
