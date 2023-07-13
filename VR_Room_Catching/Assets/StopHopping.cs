//using UnityEngine;

//public class StopHopping : MonoBehaviour
//{
//    public GameObject walker;



//    float startTime;
//    float endTime;
//    Vector3 firstPosition = new Vector3(1.4f, 0f, -0.06f);



//    // Start is called before the first frame update
//    private void Start()
//    {
//        startTime = 0f;
//        endTime = 10.2f;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        startTime += Time.deltaTime;
//        if (startTime >= endTime)
//        {
//            Debug.Log("Again");
//            walker.transform.position = firstPosition;
//            startTime = 0f;


//        }

//    }
//}

//using UnityEngine;

//public class AnimationStopper : MonoBehaviour
//{
//    public GameObject walker;
//    public Animator animator;
//    public float stopDuration = 3f;
//    public float animationStopTime = 10f;

//    private bool isAnimationStopped = false;

//    private void Start()
//    {
//        animator = GetComponent<Animator>();
//        Invoke("StopAnimation", animationStopTime); // Stop animation after animationStopTime seconds
//    }

//    private void StopAnimation()
//    {
//        if (!isAnimationStopped)
//        {
//            walker.transform.position = new Vector3(1.4f, 0f, -0.06f);
//            animator.speed = 0f; // Set animation speed to 0 to pause it
//            isAnimationStopped = true;
//            Invoke("ResumeAnimation", stopDuration); // Resume animation after stopDuration seconds
//        }
//    }

//    private void ResumeAnimation()
//    {
//        animator.speed = 1f; // Set animation speed to 1 to continue it
//        isAnimationStopped = false;
//    }
//}


using UnityEngine;

public class AnimationLooper : MonoBehaviour
{
    
    public Animator animator;
    public GameObject walker;
    public float stopDuration = 3f;
    public float animationStopTime = 10f;
    public Vector3 firstPosition = new Vector3(1.4f, 0f, -0.09f);
    private Quaternion firstRotation;


    private bool isAnimationStopped = false;

    private void Start()
    {
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


//using UnityEngine;

//public class AnimationLooper : MonoBehaviour
//{
//    public Animator animator;
//    public GameObject walker;
//    public float stopDuration = 3f;
//    public float animationStopTime = 10f;

//    private bool isAnimationStopped = false;
//    private Vector3 initialPosition;
//    private Quaternion initialRotation;

//    private void Start()
//    {
//        animator = GetComponent<Animator>();
//        initialPosition = walker.transform.position;
//        initialRotation = walker.transform.rotation;

//        Invoke("StopAnimation", animationStopTime); // Stop animation after animationStopTime seconds
//    }

//    private void StopAnimation()
//    {
//        if (!isAnimationStopped)
//        {
//            animator.speed = 0f; // Set animation speed to 0 to pause it
//            isAnimationStopped = true;
//            Invoke("ResumeAnimation", stopDuration); // Resume animation after stopDuration seconds
//        }
//    }

//    private void ResumeAnimation()
//    {
//        animator.speed = 1f; // Set animation speed to 1 to continue it
//        animator.Play(0, -1, 0f); // Start the animation from the beginning
//        isAnimationStopped = false;
//        Invoke("StopAnimation", animationStopTime); // Stop animation after animationStopTime seconds again
//    }

//    public void ResetAnimation()
//    {
//        walker.transform.position = initialPosition;
//        walker.transform.rotation = initialRotation;
//        isAnimationStopped = false;
//        animator.speed = 1f;
//        animator.Play(0, -1, 0f);
//        Invoke("StopAnimation", animationStopTime);
//    }
//}