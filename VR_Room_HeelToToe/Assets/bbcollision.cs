using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bbcollision : MonoBehaviour
{
    public Transform theMat;
    public float moveSpeed;
    private bool isReturning = false;
    public Rigidbody rb;
    private float deceleration = 2f;
    private Transform rightHand;
    public GameObject beanBag;

    private Vector3 firstPosition = new Vector3(-1.97f, 0.565f, -0.179f);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void onCollisionEnter(Collision collision)
    {
        MoveToStartPosition();

        isReturning = true;
       // rb.MoveRotation(Quaternion.identity);

        if (collision.gameObject.CompareTag("Plane") || collision.gameObject.CompareTag("Mat") || collision.gameObject.CompareTag("Target") || theMat.transform.position == this.transform.parent.position)
        {
            Debug.Log("TTTTT");
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            //this?
            this.transform.parent = theMat.transform.parent;
            rb.useGravity = true;

            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

  
    //new
    private void FixedUpdate()
    {
        

        // Check if the ball's velocity is not already zero
        if (rb.velocity.magnitude > 0f || rb.velocity.magnitude == 0f)
        {
            //rb.MoveRotation(Quaternion.identity);

            // Calculate the deceleration force
            Vector3 decelerationForce = -rb.velocity.normalized * deceleration;

            // Apply the deceleration force to the ball
            rb.AddForce(decelerationForce, ForceMode.Acceleration);

            //rb.velocity = Vector3.zero;
            //rb.angularVelocity = Vector3.zero;
            isReturning = true;
            
        }
        
    }
    

    private void MoveToStartPosition()
    {
        transform.position = rightHand.position;

        rightHand = GameObject.Find("mixamorig:RightHand").transform;

        beanBag.GetComponent<Transform>().parent = rightHand.parent;
        beanBag.GetComponent<Rigidbody>().useGravity = false;

        //float step = moveSpeed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("mixamorig:RightHand").transform.position, step);

        if (this.transform.parent == GameObject.Find("mixamorig:RightHand").transform.parent)
        {
            isReturning = false;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

}
