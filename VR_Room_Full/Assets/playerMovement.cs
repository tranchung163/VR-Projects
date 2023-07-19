using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rigidbodyComponent;
    private int superJumpsRemaining;

    public int score;
    

  
   
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() //put all key presses in update!!
    {
        //if space key pressed > bounces up
        if (Input.GetKeyDown(KeyCode.Space))
        {

            jumpKeyWasPressed = true;
            
            Debug.Log("Space key was pressed down");
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


    }
    //called once every physic update
    private void FixedUpdate() //update forces here!

    {
        rigidbodyComponent.velocity = new Vector3(horizontalInput, rigidbodyComponent.velocity.y, 0); //uses velocity from when given force

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }
        if (jumpKeyWasPressed)
        {
            float jumpPower = 5f;
            if (superJumpsRemaining > 0)
            {
                jumpPower *= 2;
                superJumpsRemaining--;
                Debug.Log("Jump power doubled!");
            }

            rigidbodyComponent.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;

        }
    }
        
      
       private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer == 7) { 
            Destroy(other.gameObject);
            superJumpsRemaining++;
            }
        
        }
    }

    

