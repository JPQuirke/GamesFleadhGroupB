using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
  
      //Public Variables - Exposed in Unity
    public float playerSpeed = 1;

    //Private Variables - for Script only
    private Rigidbody2D rb;
    private Vector2 movement;

    
    //Access the Player Sprite Renderer
    private SpriteRenderer playerSR;

  

    // Start is called before the first frame update
    void Start()
    {
        // Get access to the Rigid Body
        rb = gameObject.GetComponent<Rigidbody2D>();

        

        //Link the Player Sprite Renderer
        playerSR = gameObject.GetComponent<SpriteRenderer>();

    }

    //Update 

    // Update is called once per frame
    void Update()
    {
        

        //Check to see what direction we're moving
        if (movement.x < 0){
            //Flip the player
            playerSR.flipX = true;
        }
        else {
            playerSR.flipX = false;
        }
        
       
    }

    //Perfom Physics based updates to the Player
    void FixedUpdate(){
        //Move the Player position
        rb.MovePosition(rb.position + (movement * playerSpeed * Time.fixedDeltaTime));
    }

    void OnMove(InputValue movePosition){
        //Get the Player position
        movement = movePosition.Get<Vector2>();
    }

    
}