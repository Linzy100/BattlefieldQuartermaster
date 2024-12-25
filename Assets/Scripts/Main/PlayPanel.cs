using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayPanel : MonoBehaviour
{
    public string country;
    public Image country_image;

    public TMP_Text round_text;
    public string current_round;
    public int round = 1;
    // Start is called before the first frame update
    void Start()
    {
        country = SelectPanel.Instance.country;
        //����country����ͼƬ����
        switch (country)
        {
            case "����":
                country_image.sprite = Resources.Load<Sprite>("Art/America");
                break;
            case "����":
                country_image.sprite = Resources.Load<Sprite>("Art/Soviet");
                break;
            case "Ӣ��":
                country_image.sprite = Resources.Load<Sprite>("Art/UnitedKingdom");
                break;
            case "�¹�":
                country_image.sprite = Resources.Load<Sprite>("Art/Germany");
                break;
            case "�ձ�":
                country_image.sprite = Resources.Load<Sprite>("Art/Japan");
                break;
            case "�����":
                country_image.sprite = Resources.Load<Sprite>("Art/Italy");
                break;
            default:
                break;
        }
        current_round = "��ǰ�غϣ�"+ round.ToString();
        round_text.text = current_round;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
