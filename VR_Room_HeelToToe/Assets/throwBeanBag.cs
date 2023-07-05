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

    void comeBack()
    {
        beanBag.GetComponent<Transform>().position = rightHand.position;
        rightHand = GameObject.Find("mixamorig:RightHand").transform;
        beanBag.GetComponent<Transform>().parent = rightHand.parent;
        beanBag.GetComponent<Rigidbody>().useGravity = false;
    }
   
}
