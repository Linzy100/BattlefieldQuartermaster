using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card3502 : Card
{
    // Start is called before the first frame update
    public Card3502()
    {
        id = 3502;
        cardName = "Ǳ֧ͧԮ̫ƽ���";
        introduce = "ÿ��һ֧λ��<��̫ƽ��>����֮���ڵ��ձ����������2�֡��������������ƶѶ��� 2 ���ơ�";
        type = "����ս";
        country = "Japan";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/300/3502";
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
