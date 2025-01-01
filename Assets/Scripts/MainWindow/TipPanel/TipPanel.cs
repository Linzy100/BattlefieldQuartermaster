using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TipPanel : Singleton<TipPanel>
{
    // Update is called once per frame
    public string text =" xx";
    public TMP_Text LogText;

    void Update()
    {
        
    }

    public void OnEnable()
    {
        SetLogText(text);
    }

    public void SetLogText(string text)
    {
        LogText.text = text;
    }
    public void OnClickOKButton()
    {
        this.gameObject.SetActive(false);
    }
        
}
