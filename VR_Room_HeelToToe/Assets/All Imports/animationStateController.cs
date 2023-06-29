using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if (!isWalking && forwardPressed)
        {


            animator.SetBool(isWalkingHash, true); //set bool to be true
        }
        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);  //set bool to be false

        }

        if (!isRunning && (forwardPressed && runPressed))
        {
            {
                animator.SetBool(isRunningHash, true); //set bool to be true
            }

            if (!isRunning && (!runPressed || !forwardPressed))
            {
                animator.SetBool(isRunningHash, false);
            }



        }
    }
}
