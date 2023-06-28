using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody ballRigidbody;
    private Vector3 originalPosition;
    private bool isReturning = false;
    private Vector3 firstPosition = new Vector3(0.172f, 0.508f, 0.086f);
   

    private void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        originalPosition = firstPosition;
    }

    private void Update()
    {
        if (isReturning)
        {
            MoveToStartPosition();
            
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        isReturning = true;
    }

    private void MoveToStartPosition()
    {
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("mixamorig:RightHandIndex11").transform.position, step);

        if (this.transform.parent == GameObject.Find("mixamorig:RightHandIndex11").transform.parent)
        {
            isReturning = false;
            ballRigidbody.velocity = Vector3.zero;
            ballRigidbody.angularVelocity = Vector3.zero;
        }
    }
}