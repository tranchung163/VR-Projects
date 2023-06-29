using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Stop()
    {
        //Animator a = gameObject.GetComponen<Animator>();
        
            anim.enabled = false;
       
    }
}
 