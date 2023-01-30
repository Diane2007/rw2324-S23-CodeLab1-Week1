using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseColor : MonoBehaviour
{
    public Color toBeColor = Color.green; //the color player will become, default green 
    public bool colorChosen = false;

    public void ColorChanger(string colorName)
    {
        if (colorName == "Green")
        {
            toBeColor = new Color32(166, 255, 138, 255);
            StoreValue.playerColor = toBeColor;
            Debug.Log("The color is green.");
            
            //change the color bool from Store Value to true
            //so the little guy changes color
            colorChosen = true;
            StoreValue.colorBool = colorChosen;
        }

        else if (colorName == "Yellow")
        {
            toBeColor = new Color32(255, 251, 168, 255);
            StoreValue.playerColor = toBeColor;
            Debug.Log("The color is yellow.");
            
            colorChosen = true;
            StoreValue.colorBool = colorChosen;
        }

        else if (colorName == "Red")
        {
            toBeColor = new Color32(255, 166, 166, 255);
            StoreValue.playerColor = toBeColor;
            Debug.Log("The color is red.");
            
            colorChosen = true;
            StoreValue.colorBool = colorChosen;
        }

        else if (colorName == "Purple")
        {
            toBeColor = new Color32(206, 136, 255, 255);
            StoreValue.playerColor = toBeColor;
            Debug.Log("The color is purple.");
            
            colorChosen = true;
            StoreValue.colorBool = colorChosen;
        }

        else if (colorName == "Random")
        {
            byte R = (byte)Random.Range(0, 255);
            byte G = (byte)Random.Range(0, 255);
            byte B = (byte)Random.Range(0, 255);
            toBeColor = new Color32(R, G, B, 255);
            StoreValue.playerColor = toBeColor;
            Debug.Log("The color is random.");
            
            colorChosen = true;
            StoreValue.colorBool = colorChosen;
        }

    }
}
