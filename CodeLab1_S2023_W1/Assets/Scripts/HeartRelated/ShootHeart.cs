using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootHeart : MonoBehaviour
{
    //variable for the position of the cursor
    Vector2 cursorPos;

    //declare hearts to be public game object
    public GameObject newHeart;


    void Update()
    {
        //get updated cursor position every frame
        cursorPos = transform.position;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //heart position is slightly above the cursor
        newHeart.transform.position = new Vector3(
            cursorPos.x,
            cursorPos.y + 2f, 1);

        //spawn heart
        Spawn();

    }

    public void Spawn()
    {
        //spawns heart
        GameObject heart = Instantiate<GameObject>(newHeart);

        //destroys after 1 sec
        Destroy(heart, 1);
    }

}
