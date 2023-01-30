using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwatchScript : MonoBehaviour
{
    public void SetColor(Color newColor)
    {
        GetComponent<SpriteRenderer>().color = newColor;
    }

    public void Update()
    {
        //only when a color swatch button has been clicked on
        //the little guy changes color
        if (StoreValue.colorBool == true)
        {
            SetColor(StoreValue.playerColor);
        }
    }
}
