using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2205 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2205;
        cardName = "�������µ�";
        introduce = "����λ��<��ŷ>��һ֧���Ĺ�½��";
        type = "�¼���";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/200/2205";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
