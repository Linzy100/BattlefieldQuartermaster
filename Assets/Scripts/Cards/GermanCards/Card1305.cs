using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1305 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1305;
        cardName = "�ḻ����Դ";
        introduce = "����ļƷֽ׶�:ÿ��һ֧λ��<�ڿ���><������˹̹><��˹����>�ĵ¹�½�������1��";
        type = "״̬��";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = true;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/100/1305";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
