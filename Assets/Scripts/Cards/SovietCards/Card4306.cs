using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Card4306 : Card
{
    // Start is called before the first frame update
    void Start()
    {
        id = 4306;
        cardName = "Ů���������";
        introduce = "����ĳ��ƽ׶δ��������½����ʱ:�ɽ��ˡ�����½�����������ƶ������ƶѡ�";
        type = "״̬��";
        country = "Soviet";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;//�Ƿ��ڿ�ʼ����ִ��
        takeActionOfSupply = false;//�Ƿ��ڲ����غ�ִ��
        takeActionOfScore = false;//�Ƿ��ڼƷֻغ�ִ��
        takeActionOfGetCard = false;//�Ƿ������ƻغ�ִ��
        takeActionOfThrowCard = false;//�Ƿ��������ƻغ�ִ��
        imagePath = "Art/Cards/400/4306";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void func()
    {

    }
}
