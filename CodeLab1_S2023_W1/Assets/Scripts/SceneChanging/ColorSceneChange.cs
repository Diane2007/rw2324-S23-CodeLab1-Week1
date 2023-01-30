using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ColorSceneChange : MonoBehaviour
{
    public TextMeshProUGUI alertText;
    public AudioSource clickSound;

    public void ColorChangeScene(string newScene)
    { 
        //the scene only changes when a color is selected
        if (StoreValue.colorBool == true)
        {
            clickSound.Play();
            SceneManager.LoadScene(newScene);
            
        }

        else
        {
            clickSound.Play();
            alertText.text = "Choose a color first!";
        }
    }
}
