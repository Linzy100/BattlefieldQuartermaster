using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public plateData selectedPlate;
    public Card selectedCard;
    public string[] selectedMilitary = new string[2];  // 用于存储军队信息
    bool isPlayCard = false;

    // Start is called before the first frame update
    void Start()
    {
        // 初始化游戏管理器等
        //gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // 可以放置任何更新的逻辑
    }

    // 获取前端传过来的军队信息
    public void MilitaryGetter()
    {
        string buttonName = gameObject.name;

        string countryPart = buttonName.Substring(0, buttonName.Length - 4);
        string typePart = buttonName.Substring(buttonName.Length - 4);

        selectedMilitary[0] = countryPart;
        selectedMilitary[1] = typePart;

    }

    // 获取前端传过来的地块信息
    public void PlateGetter()
    {
        selectedPlate = GameManager.Instance.plateMananger.getCurPlateInfo(gameObject.name);
    }

    // 获取前端传过来的卡牌信息
    public void CardGetter(int cardId)
    {
        selectedCard = CardManager.Instance.GetCardById(cardId);
        //Debug.Log(selectedCard.cardName);

    }

    //让前端设置可以选择的地区为高亮,其他地区不给点击
    public List<plateData> setPlateHighLight()
    {
        List<plateData> p = new List<plateData>();
        return p;
    }
}
