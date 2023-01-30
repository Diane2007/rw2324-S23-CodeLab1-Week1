using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyColor : MonoBehaviour
{
    void Start()
    {
        GetComponent<SpriteRenderer>().color = StoreValue.playerColor;
    }
}
