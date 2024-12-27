using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardClickHandler : MonoBehaviour, IPointerClickHandler
{
    public GameObject enlargedCardPrefab; // 在Inspector中设置放大卡牌的预制体
    private GameObject enlargedCardInstance;
    private Canvas canvas;

    void Start()
    {
        // 获取Canvas引用
        canvas = GetComponentInParent<Canvas>();
        if (canvas == null)
        {
            Debug.LogError("CardClickHandler: No Canvas found in parent hierarchy!");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // 检测是左键还是右键点击
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("左键点击了卡牌: " + gameObject.name);
            // 这里添加左键点击的逻辑
            LeftClickAction();
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("右键点击了卡牌: " + gameObject.name);
            // 这里添加右键点击的逻辑
            RightClickAction();
        }
    }

    void LeftClickAction()
    {
        // 实现左键点击的具体操作

    }

    void RightClickAction()
    {
        if (enlargedCardInstance == null)
        {
            // 如果没有放大卡牌实例，创建一个
            ShowEnlargedCard();
        }
        else
        {
            // 如果有，销毁它
            HideEnlargedCard();
        }
    }

    void ShowEnlargedCard()
    {
        // 创建放大卡牌实例
        enlargedCardInstance = Instantiate(enlargedCardPrefab, canvas.transform);
        // 设置位置到Canvas中心
        enlargedCardInstance.transform.localPosition = Vector3.zero;
        // 设置图片
        Image enlargedCardImage = enlargedCardInstance.GetComponent<Image>();
        Image originalCardImage = GetComponent<Image>();
        if (enlargedCardImage != null && originalCardImage != null)
        {
            enlargedCardImage.sprite = originalCardImage.sprite;
        }
        else
        {
            Debug.LogError("CardClickHandler: Failed to set sprite for enlarged card!");
        }
        // 确保放大卡牌不能被点击
        //enlargedCardInstance.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    void HideEnlargedCard()
    {
        // 销毁放大卡牌实例
        Destroy(enlargedCardInstance);
        enlargedCardInstance = null;
    }
}
