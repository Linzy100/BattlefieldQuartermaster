using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card2303 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2303;
        cardName = "����롤����ݹ�����Դ��Ա��";
        introduce = "����ļƷֽ׶�:����<��������>��Ӣ�����������1��;����<���ô����Ӣ��½�������1�֡�";
        type = "״̬��";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = true;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/200/2303";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
