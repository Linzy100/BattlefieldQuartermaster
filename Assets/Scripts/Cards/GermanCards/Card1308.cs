using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card1308 : Card
{
    // Start is called before the first frame update
    public Card1308()
    {
        id = 1308;
        cardName = "׿Խ�滮";
        introduce = "ÿ�غ���һ�Σ�����ĳ��ƽ׶ο�ʼʱ:�ɹۿ��ƶѶ���4���ƣ�����������˳��Ż��ƶѶ���";
        type = "״̬��";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/100/1308";
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
