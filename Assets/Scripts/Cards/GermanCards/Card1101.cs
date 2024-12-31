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
        GameManager.Instance.plateMananger.changeOccupiedCountry(plateName,countryName);
        GameManager.Instance.plateUnitManager.PlaceUnit(plateName,0,0);
        if( countryName.Equals("Germany") || countryName.Equals("Japan") || countryName.Equals("Italy"))
        {
            GameManager.Instance.plateMananger.changeOccupiedCamp(plateName,"Axis");
        }
        else if (countryName.Equals("UnitedKingdom") || countryName.Equals("Soviet") || countryName.Equals("American"))
        {
            GameManager.Instance.plateMananger.changeOccupiedCamp(plateName, "Allies");
        }
    }

    // ��ѡ����������ķ����������Ҫ�Ļ�
    public override void func()
    {
        // Ĭ��ʵ��

    }
}
