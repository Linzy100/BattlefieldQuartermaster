using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2103 : Card
{
    // Start is called before the first frame update
    public Card2103()
    {
        id = 2103;
        cardName = "�齨����";
        introduce = "";
        type = "������";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/200/2103";
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
