using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card1103 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1103;
        cardName = "�齨����";
        introduce = "";
        type = "������";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/100/1103";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
