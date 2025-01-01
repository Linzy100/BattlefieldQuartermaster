using System.Collections.Generic;
using UnityEngine;

public class Card1101 : Card
{
    public Card1101()
    {
        id = 1101;
        cardName = "����½��";
        introduce = "";
        type = "������";
        country = "German";
        towords = true;
        takeActionOfPlay = true;
        takeActionOfFly = false;
        takeActionOfSupply = false;
        takeActionOfScore = false;
        takeActionOfGetCard = false;
        takeActionOfThrowCard = false;
        imagePath = "Art/Cards/100/1101";
        affectingTarget = "other";
        affectingTargetType = "Military";
    }

    // ����һ�����������в�ͬ����
    public void func(string countryName, string campName, string militaryType, string plateName)
    {
        // �����ʵ���߼�
        PlateManager.Instance.changeOccupiedCountry(plateName, countryName);
        if (countryName.Equals("Germany") || countryName.Equals("Japan") || countryName.Equals("Italy"))
        {
            PlateManager.Instance.changeOccupiedCamp(plateName, "Axis");
        }
        else if (countryName.Equals("UnitedKingdom") || countryName.Equals("Soviet") || countryName.Equals("American"))
        {
            PlateManager.Instance.changeOccupiedCamp(plateName, "Allies");
        }
    }

    // ��ѡ����������ķ����������Ҫ�Ļ�
    /*public override void func()
    {
        // Ĭ��ʵ��

    }*/

}
