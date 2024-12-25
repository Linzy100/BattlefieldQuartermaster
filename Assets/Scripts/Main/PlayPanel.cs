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
        //根据country设置图片背景
        switch (country)
        {
            case "美国":
                country_image.sprite = Resources.Load<Sprite>("Art/America");
                break;
            case "苏联":
                country_image.sprite = Resources.Load<Sprite>("Art/Soviet");
                break;
            case "英国":
                country_image.sprite = Resources.Load<Sprite>("Art/UnitedKingdom");
                break;
            case "德国":
                country_image.sprite = Resources.Load<Sprite>("Art/Germany");
                break;
            case "日本":
                country_image.sprite = Resources.Load<Sprite>("Art/Japan");
                break;
            case "意大利":
                country_image.sprite = Resources.Load<Sprite>("Art/Italy");
                break;
            default:
                break;
        }
        current_round = "当前回合："+ round.ToString();
        round_text.text = current_round;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
