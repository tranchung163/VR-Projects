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

    public float xRotation = -100f;

    private Vector3 originalPosition;

    private Vector3 firstPosition = new Vector3(-1.97f, 0.565f, -0.179f);
    //private Transform rightHand;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = beanBag.transform.position;
        rightHand = GameObject.Find("mixamorig:RightHand").transform;

        beanBag.GetComponent<Transform>().parent = rightHand.parent;
        beanBag.GetComponent<Rigidbody>().useGravity = false;

        beanBag.GetComponent<Rigidbody>().freezeRotation = true;
        Quaternion newRotation = Quaternion.Euler(xRotation, 0f, 0f);
        beanBag.GetComponent<Rigidbody>().rotation = newRotation;
    }

    void ReleaseBeanBag()
    {
        Debug.Log("Release the bean bag");
        beanBag.GetComponent<Transform>().parent = null;
        //beanBag.transform.parent = null; 
        rb = beanBag.GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.velocity = (beanBag.transform.forward * -throwForce);

    }

    void moveBallToFirst()
    {
        beanBag.transform.position = originalPosition;
        //beanBag.GetComponent<Rigidbody>().position = originalPosition; //rigidbody compoenent is center of mass!
        beanBag.GetComponent<Rigidbody>().velocity = Vector3.zero;
        beanBag.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        rightHand = GameObject.Find("mixamorig:RightHandRing3").transform; //try righthand
        beanBag.transform.position = GameObject.Find("mixamorig:RightHandRing3").transform.position; //- newVector?
        beanBag.GetComponent<Transform>().parent = rightHand.parent;
        beanBag.GetComponent<Rigidbody>().useGravity = false;
        transform.position = rightHand.position;
        beanBag.GetComponent<Transform>().position = rightHand.position;

        rb = beanBag.GetComponent<Rigidbody>();
        beanBag.GetComponent<Rigidbody>().freezeRotation = true;
        Quaternion newRotation = Quaternion.Euler(xRotation, 0f, 0f);
        beanBag.GetComponent<Rigidbody>().rotation = newRotation;

        //float step = moveSpeed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("mixamorig:RightHand").transform.position, step);

        if (this.transform.parent == GameObject.Find("mixamorig:RightHandRing3").transform.parent)
        {
           // isReturning = false;
            //rb.velocity = Vector3.zero;
            //rb.angularVelocity = Vector3.zero;
        }
    }


}
