using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public float animationDuration = 30f; // Duration of the animation in seconds
    public float restartDelay = 3f; // Delay in seconds before restarting the animation
    private Animator animator;
    private float timer;
    private bool animationRunning = true;

    private void Start()
    {
        animator = GetComponent<Animator>();
        timer = 0f;
    }

    private void Update()
    {
        if (animationRunning)
        {
            timer += Time.deltaTime;

            if (timer >= animationDuration)
            {
                // Stop the animation
                animator.enabled = false;
                animationRunning = false;

                // Start the animation again after the delay
                Invoke("RestartAnimation", restartDelay);
            }
        }
    }

    private void RestartAnimation()
    {
        // Reset the timer and start the animation
        timer = 0f;
        animator.enabled = true;
        animationRunning = true;
    }
}
