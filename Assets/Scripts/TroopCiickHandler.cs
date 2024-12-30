using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TroopCiickHandler : MonoBehaviour
{
    // 静态变量，用于跟踪当前选中的地块（按钮）
    public static Button selectedTroop = null;

    // 用于存储部队算子的原始颜色
    public Dictionary<Button, Color> originalColors = new Dictionary<Button, Color>();

    // 存储所有Troop的Button组件
    public List<Button> troopButtons = new List<Button>();

    // 选中状态的颜色
    public Color selectedColor = Color.yellow;

    // 设置透明区域不可点击的阈值
    public float alphaHitTestMinimumThreshold = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        // 获取所有子物体并添加它们的Button组件到列表中
        Button[] buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            troopButtons.Add(button);
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
        // 清理事件监听器，防止内存泄漏
        foreach (Button button in troopButtons)
        {
            button.onClick.RemoveListener(() => OnTroopClick(button));
        }
    }
}
