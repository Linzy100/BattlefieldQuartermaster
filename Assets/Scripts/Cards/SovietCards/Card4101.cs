using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card4101 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 4101;
        cardName = "����½��";
        introduce = "";
        type = "������";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/400/4101";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void func()
    {

    }
}