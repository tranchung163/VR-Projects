using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beanbagthrow : MonoBehaviour
{
    public GameObject beanBag;
    //public Transform throwStartPosition;
    public float throwForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ThrowBeanBag();
    }
    void ThrowBeanBag()
    {
        //GameObject beanBagg = Instantiate(beanBag, Quaternion.identity);
        Rigidbody beanBagRigidbody = beanBag.GetComponent<Rigidbody> ();
        beanBagRigidbody.AddForce(transform.forward * throwForce, ForceMode.Impulse);
    } 
}
