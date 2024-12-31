using System;
using UnityEngine;

[Serializable]
public class Card
{
    public int id; // ���Ʊ��
    public string cardName; // ��������
    public string introduce; // ���Ƽ��ܽ���
    public string type; // ��������
    public string country; // ��������
    public bool towords; // ���ϳ���
    public string imagePath; // ͼƬ·��
    public bool takeActionOfPlay; // �Ƿ��ڿ�ʼ�غ�ִ��
    public bool takeActionOfFly; // �Ƿ��ڿ�ʼ����ִ��
    public bool takeActionOfSupply; // �Ƿ��ڲ����غ�ִ��
    public bool takeActionOfScore; // �Ƿ��ڼƷֻغ�ִ��
    public bool takeActionOfGetCard; // �Ƿ������ƻغ�ִ��
    public bool takeActionOfThrowCard; // �Ƿ������ƻغ�ִ��
    public bool isNeedToSearch = true;//�Ƿ���ҪѰ��Ŀ��
    public bool isFinishingSearch = false;//�Ƿ����Ѱ��Ŀ��
    public string affectingTarget = "none";//�Ƿ��������Լ�����
    public string affectingTargetType = "none";//���ö������ͣ����ӣ��ؿ飩


    // ���þ�����Ϣ
    public void SetMilitaryInfo()
    {
    }

    // ����ѡ��ĵؿ���Ϣ
    public void SetSelectedPlate()
    {
    }

    // ���ÿ�����Ϣ
    public void SetCardName()
    {
    }

    public virtual void func()
    {

    }
}
