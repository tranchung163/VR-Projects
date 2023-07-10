
using UnityEngine;

public class TimerStop : MonoBehaviour
{
    private const float V = 17.199f;
    public Animator animator;
    public GameObject walker;
    public float stopDuration = 3f;
    public float animationStopTime = 10f;
    public Vector3 firstPosition;
    private Quaternion firstRotation;


    private bool isAnimationStopped = false;

    private void Start()
    {
        firstPosition = walker.transform.position;
        firstRotation = walker.transform.rotation;
        animator = GetComponent<Animator>();
        Invoke("StopAnimation", animationStopTime); // Stop animation after animationStopTime seconds
    }

    private void StopAnimation()
    {
        if (!isAnimationStopped)
        {
            animator.speed = 0f; // Set animation speed to 0 to pause it
            isAnimationStopped = true;
            Invoke("ResumeAnimation", stopDuration); // Resume animation after stopDuration seconds
            walker.transform.position = firstPosition;
            //walker.transform.rotation = firstRotation;
        }
    }

    private void ResumeAnimation()
    {
        animator.speed = 1f; // Set animation speed to 1 to continue it
        //animator.Play(0, -1, 0); // Start the animation from the beginning
        isAnimationStopped = false;
        Invoke("StopAnimation", animationStopTime); // Stop animation after animationStopTime seconds again
    }
}
