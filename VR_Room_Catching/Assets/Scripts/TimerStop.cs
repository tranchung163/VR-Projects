
//using UnityEngine;

//public class TimerStop : MonoBehaviour
//{
//    public GameObject walker;
//    bool stop = false;
//    Animator animator;
//    float startTime;
//    float endTime;
//    Vector3 endLine = new Vector3(-0.01621421f, -0.001583072f, 3.810499f); 

//    // Start is called before the first frame update
//    private void Start()
//    {
//        animator = GetComponent<Animator>();
//        startTime = 0f;
//        endTime = 22f;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        startTime += Time.deltaTime;
//        if (startTime >= endTime || walker.transform.position == endLine || GameObject.Find("Room_Modern").transform == walker.transform)
//        {
//            Debug.Log("Again");
//            transform.position = new Vector3(0f, 0f, 0f);
//            startTime = 0f;

//        }

//    }
//}



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