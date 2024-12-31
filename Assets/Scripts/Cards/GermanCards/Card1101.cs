public class Card1101 : Card
{
    public Card1101()
    {
        id = 1101;
        cardName = "建设陆军";
        introduce = "";
        type = "基础卡";
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

    // 新增一个方法，带有不同参数
    public void func(string countryName, string campName, string militaryType, string plateName)
    {
        // 具体的实现逻辑
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

    // 可选：保留父类的方法，如果需要的话
    public override void func()
    {
        // 默认实现

    }
}
