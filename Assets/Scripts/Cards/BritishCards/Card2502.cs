using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2502 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2502;
        cardName = "�����ǱͧȺ";
        introduce = "�¹�����������������ƶѶ�2���ƣ����Ƴ���λ��<���к�>�ĺ���";
        type = "����ս";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/200/2502";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
