using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card3303 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 3303;
        cardName = "�۹�֮Ұ��";
        introduce = "����ļƷֽ׶�:��<��ǵ�>��<���ɱ�>���ձ�½�������1�֡�";
        type = "״̬��";
        country = "Japan";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = true;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/300/3303";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
