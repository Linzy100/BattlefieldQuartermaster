using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlateClickHandler : MonoBehaviour
{
    // ��̬���������ڸ��ٵ�ǰѡ�еĵؿ飨��ť��
    public static Button selectedPlate = null;

    // ���ڴ洢�ؿ��ԭʼ��ɫ
    public Dictionary<Button, Color> originalColors = new Dictionary<Button, Color>();

    // ѡ��״̬����ɫ
    public Color selectedColor = Color.yellow;

    // �洢���еؿ��Button���
    public List<Button> plateButtons = new List<Button>();

    // ����͸�����򲻿ɵ������ֵ
    public float alphaHitTestMinimumThreshold = 0.5f;

    void Start()
    {
        // ��ȡ���������岢������ǵ�Button������б���
        Button[] buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            plateButtons.Add(button);
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
            button.onClick.AddListener(() => OnPlateClick(button));
        }
    }

    void OnPlateClick(Button clickedButton)
    {
        if(selectedPlate == null || selectedPlate != clickedButton)
        {
            if (selectedPlate != null)
            {
                UnselectPlate(selectedPlate);
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
            selectedPlate = plateButton;
        }
    }

    void UnselectPlate(Button plateButton)
    {
        Image plateImage = plateButton.GetComponent<Image>();
        if (plateImage != null && originalColors.ContainsKey(plateButton))
        {
            plateImage.color = originalColors[plateButton];
            if (selectedPlate == plateButton)
            {
                selectedPlate = null;
            }
        }
    }

    void OnDestroy()
    {
        // �����¼�����������ֹ�ڴ�й©
        foreach (Button button in plateButtons)
        {
            button.onClick.RemoveListener(() => OnPlateClick(button));
        }
    }
}
