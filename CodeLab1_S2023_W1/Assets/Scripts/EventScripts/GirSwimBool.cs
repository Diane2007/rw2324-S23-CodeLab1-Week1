using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirSwimBool : MonoBehaviour
{
    public bool girSwimBool;

    public void GirSwimChanger()
    {
        //set the swim to true after changing to the swim scene
        girSwimBool = true;
        //now assign this value to the static girIsSwimming value from EventManagement
        EventManagement.girIsSwimming = girSwimBool;

    }
}
