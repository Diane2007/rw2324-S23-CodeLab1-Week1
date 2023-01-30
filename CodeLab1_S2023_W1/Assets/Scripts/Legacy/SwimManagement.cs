using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwimManagement : MonoBehaviour
{
    //speed of the animals
    public float speed = 1;
    public float eleSpeed;
    public float girSpeed;

    //rigid body
    Rigidbody2D rb;

    //frequency and amplitude
    public float freq = 1;
    public float amp = 0.5f;

    //where the animals start and move to
    Vector2 startPos, movePos;

    // Start is called before the first frame update
    void Start()
    {
        //giraffe's speed is 2 times elephant's speed (in this game, not in the wild)
        girSpeed = speed;
        eleSpeed = - speed / 2f;    //negative because elephant phases left

        //init the start and move position
        startPos = transform.position;  //where the sprite is
        movePos = Vector2.zero;         //no movement yet

        //get the component
        rb = GetComponent<Rigidbody2D>();
    }

    public enum MoveType
    {
        EleHorizontal,
        GirHorizontal
    }

    //set the default movement mode: horizontal
    public MoveType moveMode = MoveType.EleHorizontal;

    // Update is called once per frame
    void Update()
    {
        //how the different movement modes work
        switch (moveMode)
        {
            //how the elephant moves horizontally
            case MoveType.EleHorizontal:

                //now we calculate the movement
                movePos.x += eleSpeed * Time.deltaTime;

                //if the elephant is too far left, turn around
                if(transform.position.x < -5f)
                {
                    //move right
                    eleSpeed = speed/2f;

                    //flip the animal
                    gameObject.transform.localScale = new Vector3(-0.1f, 0.1f, 0.1f);

                }

                //if the elephant is too far right, turn around
                if(transform.position.x > 5.5f)
                {
                    //move left
                    eleSpeed = -speed/2f;

                    //flip the animal
                    gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                }
                break;

            //how the giraffe moves horizontally
            case MoveType.GirHorizontal:

                //calculate movement
                movePos.x += girSpeed * Time.deltaTime;

                //if too far right, turn around
                if(transform.position.x > 4.2f)
                {
                    girSpeed = -speed;
                    gameObject.transform.localScale = new Vector3(-0.2f, 0.2f, 0.2f);
                }

                //if too far left, turn around
                if(transform.position.x < -5.5f)
                {
                    girSpeed = speed;
                    gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                }
                break;
        }

        //use moveposition to move with physics
        rb.MovePosition(startPos + movePos);
    }
}
