using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Card2201 : Card
{
    // Start is called before the first frame update
    public Card2201()
    {
        id = 2201;
        cardName = "ʷĩ��ǿ����Ӣ��ϵ";
        introduce = "��<�����ϲ�>����½������<�ϴ�����>��<��������>���ٺ���";
        type = "�¼���";
        country = "British";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/200/2201";
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
