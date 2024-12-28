using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlateClickHandler : MonoBehaviour
{
    // 静态变量，用于跟踪当前选中的地块（按钮）
    public static Button selectedPlate = null;

    // 用于存储地块的原始颜色
    public Dictionary<Button, Color> originalColors = new Dictionary<Button, Color>();

    // 选中状态的颜色
    public Color selectedColor = Color.yellow;

    // 存储所有地块的Button组件
    public List<Button> plateButtons = new List<Button>();

    // 设置透明区域不可点击的阈值
    public float alphaHitTestMinimumThreshold = 0.5f;

    void Start()
    {
        // 获取所有子物体并添加它们的Button组件到列表中
        Button[] buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            plateButtons.Add(button);
            // 存储每个Button的原始颜色
            Image buttonImage = button.GetComponent<Image>();
            if (buttonImage != null)
            {
                originalColors[button] = buttonImage.color;
                // 设置透明区域不可点击
                buttonImage.alphaHitTestMinimumThreshold = alphaHitTestMinimumThreshold;
            }
            else
            {
                Debug.LogWarning("No Image component found on button: " + button.gameObject.name);
            }
            // 添加点击事件监听器
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
        // 清理事件监听器，防止内存泄漏
        foreach (Button button in plateButtons)
        {
            button.onClick.RemoveListener(() => OnPlateClick(button));
        }
    }
}
