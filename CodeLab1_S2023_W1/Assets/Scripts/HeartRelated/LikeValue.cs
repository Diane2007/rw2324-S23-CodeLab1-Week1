using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LikeValue : MonoBehaviour
{
    //declare public variables to store elephant and giraffe's like for you
    public int elephantLike;
    public int giraffeLike;

    //a bool for checking if the animals can increase relationship with you right now
    bool elephantLikeDisabled = false;
    bool giraffeLikeDisabled = false;

    //elephantLike and giraffeLike should equal to values in StoreLike at the beginning of the game
    void Start()
    {
        elephantLike = StoreValue.totalEleLike;
        giraffeLike = StoreValue.totalGirLike;
    }

    //enable relationship increase after 2 seconds
    IEnumerator EnableLike()
    {
        //if elephant relationship increase is disabled
        if (elephantLikeDisabled == true)
        {
            //wait for 2 seconds
            yield return new WaitForSeconds(2);

            //player is now able to increase relationship with elephant again
            elephantLikeDisabled = false;
        }

        //if giraffe relationship increase is disabled
        if (giraffeLikeDisabled == true)
        {
            yield return new WaitForSeconds(2);

            giraffeLikeDisabled = false;
        }
    }

    //check and call true once collide with each animal
    void OnCollisionEnter2D(Collision2D animalCollision)
    {
        if (elephantLikeDisabled == false)
        {

            //touching elephant
            if (animalCollision.gameObject.tag == "Elephant")
            {
                //elephant relationship goes up 1
                elephantLike++;
                StoreValue.totalEleLike = elephantLike;  //assign the new value to the stored elephant like value
                Debug.Log("Relationship with elephant is: " + StoreValue.totalEleLike);

                //player now cannot increase relationship with elephant
                //until the following goes to false;
                elephantLikeDisabled = true;
                Debug.Log("Unable to interact with elephant for 2 seconds");

                //enable relationship increase after 2 seconds
                StartCoroutine(EnableLike());
                Debug.Log("Able to interact with elephant");
            }

        }

        if(giraffeLikeDisabled == false) {
                //touching giraffe
                if (animalCollision.gameObject.tag == "Giraffe")
                {
                    //giraffe relationship goes up 1
                    giraffeLike++;
                    StoreValue.totalGirLike = giraffeLike;   //assign the new value to the stored gir like value
                    Debug.Log("Relationship with giraffe is: " + StoreValue.totalGirLike);

                    //player now cannot increase relationship with giraffe
                    //until the following goes to false;
                    giraffeLikeDisabled = true;
                    Debug.Log("Unable to interact with giraffe for 2 seconds");

                    //enable relationship increase after 2 seconds
                    StartCoroutine(EnableLike());
                    Debug.Log("Able to interact with giraffe");
                }
            }
    }




}
