using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card3401 : Card
{
    // Start is called before the first frame update
    public Card3401()
    {
        id = 3401;
        cardName = "������";
        introduce = "���㷢��½ս�󴥷�:��ս�����������ڵ�������½ս��";
        type = "�Բ߿�";
        country = "Japan";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/300/3401";
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
