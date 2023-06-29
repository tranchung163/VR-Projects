using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bbcollision : MonoBehaviour
{
    public Transform theMat;
    public Rigidbody rb;
    private float deceleration = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void onCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Plane") || collision.gameObject.CompareTag("Mat") || collision.gameObject.CompareTag("Target") || theMat.transform.position == this.transform.parent.position)
        {
            Debug.Log("TTTTT");
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;


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
            // Calculate the deceleration force
            Vector3 decelerationForce = -rb.velocity.normalized * deceleration;

            // Apply the deceleration force to the ball
            rb.AddForce(decelerationForce, ForceMode.Acceleration);
        }
    }

}
