using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public plateData selectedPlate;
    public Card selectedCard;
    public string[] selectedMilitary = new string[2];  // ���ڴ洢������Ϣ
    bool isPlayCard = false;

    // Start is called before the first frame update
    void Start()
    {
        // ��ʼ����Ϸ��������
        //gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���Է����κθ��µ��߼�
    }

    // ��ȡǰ�˴������ľ�����Ϣ
    public void MilitaryGetter()
    {
        string buttonName = gameObject.name;

        string countryPart = buttonName.Substring(0, buttonName.Length - 4);
        string typePart = buttonName.Substring(buttonName.Length - 4);

        selectedMilitary[0] = countryPart;
        selectedMilitary[1] = typePart;

    }

    // ��ȡǰ�˴������ĵؿ���Ϣ
    public void PlateGetter()
    {
        selectedPlate = GameManager.Instance.plateMananger.getCurPlateInfo(gameObject.name);
    }

    // ��ȡǰ�˴������Ŀ�����Ϣ
    public void CardGetter(int cardId)
    {
        selectedCard = CardManager.Instance.GetCardById(cardId);
        //Debug.Log(selectedCard.cardName);

    }

    //��ǰ�����ÿ���ѡ��ĵ���Ϊ����,���������������
    public List<plateData> setPlateHighLight()
    {
        List<plateData> p = new List<plateData>();
        return p;
    }
}
