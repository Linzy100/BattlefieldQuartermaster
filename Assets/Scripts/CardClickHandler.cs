using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardClickHandler : MonoBehaviour, IPointerClickHandler
{
    public GameObject enlargedCardPrefab; // ��Inspector�����÷Ŵ��Ƶ�Ԥ����
    public static GameObject enlargedCardInstance;
    public Canvas canvas;

    public static CardClickHandler selectedCard = null; // ��̬��������¼��ǰѡ�еĿ���
    public Vector3 originalPosition; // �洢���Ƶ�ԭʼλ��

    void Start()
    {
        // ��ȡCanvas����
        canvas = GetComponentInParent<Canvas>();
        if (canvas == null)
        {
            Debug.LogError("CardClickHandler: No Canvas found in parent hierarchy!");
        }

        // �洢���Ƶ�ԭʼλ��
        originalPosition = transform.localPosition;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            //Debug.Log("�������˿���: " + gameObject.name);
            LeftClickAction();
        }
        else if (eventData.button == PointerEventData.InputButton.Right && enlargedCardPrefab != null)
        {
            //Debug.Log("�Ҽ�����˿���: " + gameObject.name);
            RightClickAction();
        }
    }

    void LeftClickAction()
    {
        // �����ǰû��ѡ�еĿ��ƣ�����ѡ�еĲ������ſ���
        if (selectedCard == null || selectedCard != this)
        {
            // ȡ��֮ǰѡ�еĿ��Ƶ�ѡ��Ч��
            if (selectedCard != null)
            {
                selectedCard.UnselectCard();
            }
            // ѡ�е�ǰ����
            SelectCard();
        }
        else
        {
            // �����ǰѡ�еľ������ſ��ƣ���ȡ��ѡ��
            UnselectCard();
        }
    }

    void SelectCard()
    {
        // �����ƶ�������Ϊѡ��Ч��
        // ������������ƶ�50��λ������Ը�����Ҫ�������ֵ
        Vector3 newPosition = originalPosition + new Vector3(0, 35, 0);
        transform.localPosition = newPosition;
        selectedCard = this; // ����Ϊ��ǰѡ�еĿ���
        Debug.Log("ѡ�п���: " + selectedCard.gameObject.name);
    }

    void UnselectCard()
    {
        // �ƻ�ԭʼλ��ȡ��ѡ��Ч��
        transform.localPosition = originalPosition;
        if (selectedCard == this)
        {
            selectedCard = null; // ȡ��ѡ��״̬
            //Debug.Log(" ȡ��ѡ�п���: " + gameObject.name);
        }
    }

    void RightClickAction()
    {   //ʵ���Ҽ�����ľ������(����Ļ���Ĵ���һ���Ŵ��Ŀ���ͼƬ)
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
