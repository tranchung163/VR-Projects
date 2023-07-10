using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwBeanBag : MonoBehaviour
{
    public GameObject beanBag;
    public Transform throwPosition;
    public float throwForce = 100f;
    private Transform rightHand;
    public Rigidbody rb;
    public float moveSpeed;

    public float xRotation = -130f;

    private Vector3 originalPosition;
    private Vector3 forwardVector;

    private Vector3 aVector = new Vector3(0f, -0.03f, 0.04f);
    private Vector3 firstPosition = new Vector3(-1.97f, 0.681f, -0.133f);
    public Vector3 throwForward = new Vector3(100f, 10f, 10f);
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

        //beanBag.transform.forward = throwForward;
    }

    void ReleaseBeanBag()
    {
        Debug.Log("Release the bean bag");

        //forwardVector = beanBag.transform.forward;

        beanBag.GetComponent<Transform>().parent = null;
        beanBag.transform.parent = null;
        rb = beanBag.GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.velocity = (beanBag.transform.forward * -throwForce); //throwForward

        //beanBag.transform.position += forwardVector * (throwForce * Time.deltaTime);

        //beanBag.GetComponent<Rigidbody>().AddForce(throwForward * throwForce, ForceMode.Impulse);

        //Vector3 throwForceVector = throwForward * throwForce;
        //rb.AddForce(throwForceVector, ForceMode.Impulse);
        //rb.AddForce(throwForceVector, ForceMode.VelocityChange);

    }

    void moveBallToFirst()
    {
        //beanBag.transform.position = originalPosition;
        beanBag.GetComponent<Rigidbody>().position = originalPosition; //rigidbody compoenent is center of mass!
        beanBag.GetComponent<Rigidbody>().velocity = Vector3.zero;
        beanBag.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        rightHand = GameObject.Find("mixamorig:RightHandRing3").transform; //try righthand
        beanBag.transform.position = GameObject.Find("mixamorig:RightHandRing3").transform.position - aVector;
        beanBag.GetComponent<Transform>().parent = rightHand.parent;
        beanBag.GetComponent<Rigidbody>().useGravity = false;




        //transform.position = rightHand.position;
        //beanBag.GetComponent<Transform>().position = rightHand.position;

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
