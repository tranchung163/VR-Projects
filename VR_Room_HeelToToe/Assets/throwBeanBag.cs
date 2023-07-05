using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwBeanBag : MonoBehaviour
{
    public GameObject beanBag;
    public Transform throwPosition;
    public float throwForce = 10f;
    private Transform rightHand;
    public Rigidbody rb;
    public float moveSpeed;
    private Vector3 firstPosition = new Vector3(-1.97f, 0.565f, -0.179f);
    //private Transform rightHand;

    // Start is called before the first frame update
    void Start()
    {
        rightHand = GameObject.Find("mixamorig:RightHand").transform;

        beanBag.GetComponent<Transform>().parent = rightHand.parent;
        beanBag.GetComponent<Rigidbody>().useGravity = false;
    }

    void ReleaseBeanBag()
    {
        Debug.Log("Release the bean bag");
        beanBag.GetComponent<Transform>().parent = null;
        rb = beanBag.GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.velocity = (beanBag.transform.forward * -throwForce);

    }
    void moveBallToFirst()
    {
        rightHand = GameObject.Find("mixamorig:RightHandRing3").transform;
        beanBag.transform.position = GameObject.Find("mixamorig:RightHandRing3").transform.position; //- newVector?
        beanBag.GetComponent<Transform>().parent = rightHand.parent;
        beanBag.GetComponent<Rigidbody>().useGravity = false;
        transform.position = rightHand.position;

      

        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("mixamorig:RightHand").transform.position, step);

        if (this.transform.parent == GameObject.Find("mixamorig:RightHandRing3").transform.parent)
        {
           // isReturning = false;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

}
