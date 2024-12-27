using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touch : MonoBehaviour
{
    //public Button pac;
    public List<Image> MapFragments;
    // Start is called before the first frame update
    void Start()
    {
        MapFragments = new List<Image>();
        //找到cover下的所有图片子物体添加到MapFragments列表中
        foreach (Transform child in transform)
        {
            MapFragments.Add(child.GetComponent<Image>());
        }
        foreach (Image img in MapFragments)
        {
            img.alphaHitTestMinimumThreshold = 0.5f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
