using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2203 : Card
{
    // Start is called before the first frame update
    public Card2203()
    {
        id = 2203;
        cardName = "��������������˹�����λ";
        introduce = "��<�Ͷ���>����һ֧���Ĺ�½������<�Ͷ���>����Ӣ��½��";
        type = "�¼���";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/200/2203";
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
