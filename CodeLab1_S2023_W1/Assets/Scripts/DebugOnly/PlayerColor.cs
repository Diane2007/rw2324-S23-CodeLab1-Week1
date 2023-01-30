using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    private Color toBeColor = Color.white;           //the color player will become, default white


    public void SetColor(Color newColor)
    {
        GetComponent<SpriteRenderer>().color = newColor;
    }

    
    //these are our choices of color player choose at the beginning
    public enum ColorChoice
    {
        Green,
        Blue,
        Orange,
        Red,
        Random
    }

    //choose the default color
    public ColorChoice chosenColor = ColorChoice.Green;

    public void ChangeColor()
    {
        switch (chosenColor)
        {
            case ColorChoice.Green:
                toBeColor = new Color32(0, 255, 0, 255) ;
                break;

            case ColorChoice.Blue:
                toBeColor = new Color32(0, 172, 255, 255);
                break;

            case ColorChoice.Orange:
                toBeColor = new Color32(255, 131, 0, 255);
                break;

            case ColorChoice.Red:
                toBeColor = new Color32(237, 22, 18, 255);
                break;

            case ColorChoice.Random:
                byte R = (byte)Random.Range(0, 255);
                byte G = (byte)Random.Range(0, 255);
                byte B = (byte)Random.Range(0, 255);
                toBeColor = new Color32(R, G, B, 255);
                break;
        }
    }

}
