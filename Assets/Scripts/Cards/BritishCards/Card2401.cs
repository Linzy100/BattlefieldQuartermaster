using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2401 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2401;
        cardName = "��Ǳս��";
        introduce = "�����Ĺ����������ս����ʱ����:�ˡ�����ս����Ч����Ч��";
        type = "�Բ߿�";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/200/2401";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
