using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card6205 : Card
{
    // Start is called before the first frame update
    public Card6205()
    {
        id = 6205;
        cardName = "����Ԯ��";
        introduce = "ѡ��Ӣ��������������ɴ��һ�����ƣ���һ����";
        type = "�¼���";
        country = "America";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/600/6205";
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
