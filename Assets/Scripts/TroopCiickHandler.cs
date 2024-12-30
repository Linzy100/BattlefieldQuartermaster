using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TroopCiickHandler : MonoBehaviour
{
    // ��̬���������ڸ��ٵ�ǰѡ�еĵؿ飨��ť��
    public static Button selectedTroop = null;

    // ���ڴ洢�������ӵ�ԭʼ��ɫ
    public Dictionary<Button, Color> originalColors = new Dictionary<Button, Color>();

    // �洢����Troop��Button���
    public List<Button> troopButtons = new List<Button>();

    // ѡ��״̬����ɫ
    public Color selectedColor = Color.yellow;

    // ����͸�����򲻿ɵ������ֵ
    public float alphaHitTestMinimumThreshold = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        // ��ȡ���������岢������ǵ�Button������б���
        Button[] buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            troopButtons.Add(button);
            // �洢ÿ��Button��ԭʼ��ɫ
            Image buttonImage = button.GetComponent<Image>();
            if (buttonImage != null)
            {
                originalColors[button] = buttonImage.color;
                // ����͸�����򲻿ɵ��
                buttonImage.alphaHitTestMinimumThreshold = alphaHitTestMinimumThreshold;
            }
            else
            {
                Debug.LogWarning("No Image component found on button: " + button.gameObject.name);
            }
            // ��ӵ���¼�������
            button.onClick.AddListener(() => OnTroopClick(button));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTroopClick(Button clickedButton)
    {
        if (selectedTroop == null || selectedTroop != clickedButton)
        {
            if (selectedTroop != null)
            {
                UnselectPlate(selectedTroop);
            }
            SelectPlate(clickedButton);
        }
        else
        {
            UnselectPlate(clickedButton);
        }
    }

    void SelectPlate(Button plateButton)
    {
        Image plateImage = plateButton.GetComponent<Image>();
        if (plateImage != null)
        {
            plateImage.color = selectedColor;
            selectedTroop = plateButton;
        }
    }

    void UnselectPlate(Button troopButton)
    {
        Image plateImage = troopButton.GetComponent<Image>();
        if (plateImage != null && originalColors.ContainsKey(troopButton))
        {
            plateImage.color = originalColors[troopButton];
            if (selectedTroop == troopButton)
            {
                selectedTroop = null;
            }
        }
    }

    void OnDestroy()
    {
        // �����¼�����������ֹ�ڴ�й©
        foreach (Button button in troopButtons)
        {
            button.onClick.RemoveListener(() => OnTroopClick(button));
        }
    }
}
