using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardClickHandler : MonoBehaviour, IPointerClickHandler
{
    public GameObject enlargedCardPrefab; // 在Inspector中设置放大卡牌的预制体
    public static GameObject enlargedCardInstance;
    public Canvas canvas;

    public static CardClickHandler selectedCard = null; // 静态变量，记录当前选中的卡牌
    public Vector3 originalPosition; // 存储卡牌的原始位置

    void Start()
    {
        // 获取Canvas引用
        canvas = GetComponentInParent<Canvas>();
        if (canvas == null)
        {
            Debug.LogError("CardClickHandler: No Canvas found in parent hierarchy!");
        }

        // 存储卡牌的原始位置
        originalPosition = transform.localPosition;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            //Debug.Log("左键点击了卡牌: " + gameObject.name);
            LeftClickAction();
        }
        else if (eventData.button == PointerEventData.InputButton.Right && enlargedCardPrefab != null)
        {
            //Debug.Log("右键点击了卡牌: " + gameObject.name);
            RightClickAction();
        }
    }

    void LeftClickAction()
    {
        // 如果当前没有选中的卡牌，或者选中的不是这张卡牌
        if (selectedCard == null || selectedCard != this)
        {
            // 取消之前选中的卡牌的选中效果
            if (selectedCard != null)
            {
                selectedCard.UnselectCard();
            }
            // 选中当前卡牌
            SelectCard();
        }
        else
        {
            // 如果当前选中的就是这张卡牌，则取消选中
            UnselectCard();
        }
    }

    void SelectCard()
    {
        // 向上移动卡牌作为选中效果
        // 这里假设向上移动50单位，你可以根据需要调整这个值
        Vector3 newPosition = originalPosition + new Vector3(0, 35, 0);
        transform.localPosition = newPosition;
        selectedCard = this; // 设置为当前选中的卡牌
        Debug.Log("选中卡牌: " + selectedCard.gameObject.name);
    }

    void UnselectCard()
    {
        // 移回原始位置取消选中效果
        transform.localPosition = originalPosition;
        if (selectedCard == this)
        {
            selectedCard = null; // 取消选中状态
            //Debug.Log(" 取消选中卡牌: " + gameObject.name);
        }
    }

    void RightClickAction()
    {   //实现右键点击的具体操作(在屏幕中心创建一个放大后的卡牌图片)
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
