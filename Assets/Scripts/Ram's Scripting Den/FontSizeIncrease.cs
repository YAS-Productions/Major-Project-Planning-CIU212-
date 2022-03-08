using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontSizeIncrease : MonoBehaviour
{
   
    public int hoverSize;
    public int startSize;

    Text text;
    RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        rectTransform = GetComponent<RectTransform>();
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseFontSize()
    {
        text.fontSize = hoverSize;
        Debug.Log("I'm over this bitch");
    }

    public void DecreaseFontSize()
    {
        text.fontSize = startSize;
    }
}
