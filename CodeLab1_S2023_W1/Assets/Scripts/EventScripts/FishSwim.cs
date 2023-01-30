using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class FishSwim : MonoBehaviour
{
    //a standard speed for fish
    public float speed = 1;
    
    //vars to randomize fish speed
    public float fishSpeed;     //speed for individual fish
    public float randomizer;    //used to randomize fishSpeed

    //where the fish start and move to
    private Vector2 startPos, movePos;
    
    //get the rigidbody
    private Rigidbody2D rb;

    void Start()
    {
        //link rb with the gameobject's rigidbody
        rb = GetComponent<Rigidbody2D>();
        
        //randomize fishSpeed for each fish
        randomizer = Random.Range(0.5f, 2f);
        fishSpeed = randomizer * speed;
        
        //get the fish's start position and moving position
        startPos = transform.position;
        movePos = Vector2.zero;     //not moving yet
    }

    void Update()
    {
        //calculate movement
        movePos.x += fishSpeed * Time.deltaTime;
        
        //the fish will not get out of the scene
        //turn around when too far right
        if (transform.position.x > 9.4f)
        {
            fishSpeed = -randomizer * speed;
            gameObject.transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
        }
        //turn around when too far left
        if (transform.position.x < -9.5f)
        {
            fishSpeed = randomizer * speed;
            gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
        
        //move
        rb.MovePosition(startPos + movePos);
    }
}
