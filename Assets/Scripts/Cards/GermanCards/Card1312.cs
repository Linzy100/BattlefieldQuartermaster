using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1312 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1312;
        cardName = "Ⱥ��ս��";
        introduce = "�κ���Ҵ�����С�Ǳͧ�������ġ�����ս����ʱ:����Ŀ�������õĿ�������2����<˹������ά��>�е¹�½����Ϊ 3�š�";
        type = "״̬��";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/100/1312";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
