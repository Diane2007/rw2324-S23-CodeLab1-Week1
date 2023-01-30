using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchButt : MonoBehaviour
{

    //declare hearts to be public game object
    public GameObject buttText;


    private void OnCollisionEnter2D(Collision2D touchButt)
    {
        if (touchButt.gameObject.tag == "Player")
        {
            //the text appears at the middle of the screen
            buttText.transform.position = new Vector3(0, 0, 0);

                SpawnButt();
        }
    }

    public void SpawnButt()
    {
        //spawn butt text when player touches the animal's butt
        //their tail to be specific
        GameObject butt = Instantiate<GameObject>(buttText);
        
        Destroy(butt, 1);
    }
    
}
