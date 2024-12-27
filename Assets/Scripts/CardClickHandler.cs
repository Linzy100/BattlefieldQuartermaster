using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardClickHandler : MonoBehaviour, IPointerClickHandler
{
    public GameObject enlargedCardPrefab; // ��Inspector�����÷Ŵ��Ƶ�Ԥ����
    private GameObject enlargedCardInstance;
    private Canvas canvas;

    void Start()
    {
        // ��ȡCanvas����
        canvas = GetComponentInParent<Canvas>();
        if (canvas == null)
        {
            Debug.LogError("CardClickHandler: No Canvas found in parent hierarchy!");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // �������������Ҽ����
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("�������˿���: " + gameObject.name);
            // ����������������߼�
            LeftClickAction();
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("�Ҽ�����˿���: " + gameObject.name);
            // ��������Ҽ�������߼�
            RightClickAction();
        }
    }

    void LeftClickAction()
    {
        // ʵ���������ľ������

    }

    void RightClickAction()
    {
        if (enlargedCardInstance == null)
        {
            // ���û�зŴ���ʵ��������һ��
            ShowEnlargedCard();
        }
        else
        {
            // ����У�������
            HideEnlargedCard();
        }
    }

    void ShowEnlargedCard()
    {
        // �����Ŵ���ʵ��
        enlargedCardInstance = Instantiate(enlargedCardPrefab, canvas.transform);
        // ����λ�õ�Canvas����
        enlargedCardInstance.transform.localPosition = Vector3.zero;
        // ����ͼƬ
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
        // ȷ���Ŵ��Ʋ��ܱ����
        //enlargedCardInstance.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    void HideEnlargedCard()
    {
        // ���ٷŴ���ʵ��
        Destroy(enlargedCardInstance);
        enlargedCardInstance = null;
    }
}
