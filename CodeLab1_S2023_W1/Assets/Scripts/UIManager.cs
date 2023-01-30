using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Like you text")]
    //connect the two text messages with this script
    public GameObject elephantText;
    public GameObject giraffeText;
    public GameObject eleSwimText;
    public GameObject girSwimText;
    public GameObject eleSwimButton;
    public GameObject girSwimButton;


    [Header("Relationship")]
    //vars to connect with player's components
    public LikeValue giraffeRelationship;
    public LikeValue elephantRelationship;

    [Header("Timer")]
    //an alarm so texts appear and disappear
    float eleTextCounter;
    float girTextCounter;


    void Start()
    {
        //when game starts, the texts are transparent
        giraffeText.SetActive(false);
        elephantText.SetActive(false);
        eleSwimText.SetActive(false);
        girSwimText.SetActive(false);
        eleSwimButton.SetActive(false);
        girSwimButton.SetActive(false);

        //alarm starts from 0
        girTextCounter = 0;
        eleTextCounter = 0;
        
    }

    void Update()
    {

        //the texts only show up when animals' relationship are at 3 with you
        if (giraffeRelationship.giraffeLike == 3)
        {
            //the text reappears
            giraffeText.SetActive(true);

            //start counter
            girTextCounter += Time.deltaTime;
            Debug.Log("giraffe text counter is " + girTextCounter);

            //text becomes invisible after 2 seconds
            if (girTextCounter > 2)
            {
                //disables text again
                giraffeText.SetActive(false);
            }

        }

        if (elephantRelationship.elephantLike == 3)
        {
            //the text reappears
            elephantText.SetActive(true);

            //start counter
            eleTextCounter += Time.deltaTime;
            Debug.Log("elephant text counter is " + eleTextCounter);

            //text becomes invisible after 2 seconds
            if (eleTextCounter > 2)
            {
                //disables text again
                elephantText.SetActive(false);
            }
        }


        //when the relationship is 5
        //animals invite you to swim


            if (girSwimText != null && giraffeRelationship.giraffeLike == 5)
            {
                //when giraffe relationship with you is 5
                //give an invite to swim
                girSwimText.SetActive(true);
                girSwimButton.SetActive(true);
                eleSwimText.SetActive(false);
            }


            if (eleSwimText != null && elephantRelationship.elephantLike == 5)
            {
                //when elephant relationship with you is 5
                //give an invite to swim
                eleSwimText.SetActive(true);
                eleSwimButton.SetActive(true);
                girSwimText.SetActive(false);
            }

        //after the swim event runs, it gets destroyed and won't run again
        if(EventManagement.girIsSwimming == true)
        {
            Destroy(girSwimText, 0);
            Destroy(girSwimButton, 0);
        }

        if(EventManagement.eleIsSwimming == true)
        {
            Destroy(eleSwimText, 0);
            Destroy(eleSwimButton, 0);
        }
        

    }

}