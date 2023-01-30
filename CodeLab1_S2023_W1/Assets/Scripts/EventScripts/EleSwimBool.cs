using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleSwimBool : MonoBehaviour
{
    public bool eleSwimBool;

    public void eleSwimChanger()
    {
        eleSwimBool = true;
        EventManagement.eleIsSwimming = eleSwimBool;
    }
}
