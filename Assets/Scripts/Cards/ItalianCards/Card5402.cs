using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card5402 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 5402;
        cardName = "����ŵɽ";
        introduce = "��λ��<�����>�����Ĺ�½�������Ƴ�ʱ����:���غϸ�½�����ᱻ�Ƴ���";
        type = "�Բ߿�";
        country = "Italian";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/500/5402";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
