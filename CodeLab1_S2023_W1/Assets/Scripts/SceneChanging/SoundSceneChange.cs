using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSceneChange : MonoBehaviour
{
    void Awake()
    {
        //the sound will not get destroyed when changing scene
        DontDestroyOnLoad(this);
    }

}
