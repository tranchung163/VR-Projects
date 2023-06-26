
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    //BallScript throwTheBall = new BallScript();
    //// Update is called once per frame
    //public void ThrowingBall()
    //{
    //    Debug.Log("Throwball");
    //    throwTheBall.ReleaseBall();
    //}
    public GameObject ballPrefab;
    public Transform throwPosition;
    public float throwForce = 10f;
    private Transform rightHand;
    public Rigidbody rb;
    private Vector3 aVector = new Vector3(0f, -0.03f, 0.04f);
    public Vector3 throwDirection = new Vector3(0f, 0f, 0f);
    

    void Start()
    {
        
        rightHand = GameObject.Find("mixamorig:RightHand").transform;
        ballPrefab.transform.position = GameObject.Find("mixamorig:RightHandIndex1").transform.position;
        ballPrefab.GetComponent<Transform>().parent = rightHand.parent;
        ballPrefab.GetComponent<Rigidbody>().useGravity = false;
    }

    void ReleaseBall()
    {
        Debug.Log("Release the ball");
        //GameObject ball = Instantiate(ballPrefab, throwPosition.position, Quaternion.identity);
        //Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        ballPrefab.GetComponent<Transform>().parent = null;
        rb = ballPrefab.GetComponent<Rigidbody>();
        rb.useGravity = true;
        //rb.velocity = (ballPrefab.transform.forward * throwForce);


        //ballRigidbody.AddForce(throwPosition.forward * throwForce, ForceMode.Impulse);
        //ballPrefab.GetComponent<Rigidbody>().AddForce(ballPrefab.transform.forward * throwForce);
        //GameObject ball = Instantiate(ballPrefab, throwPosition.position, Quaternion.identity);
        //Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        ballPrefab.GetComponent<Rigidbody>().AddForce(throwDirection * throwForce, ForceMode.Impulse);
        //GameObject ball = Instantiate(ballPrefab, throwPosition.position, throwPosition.rotation);
        //Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        //ballRigidbody.AddForce(throwPosition.forward * throwForce, ForceMode.Impulse);
    }

    void catchBall()
    {
        Debug.Log("Catch the ball");
        rightHand = GameObject.Find("mixamorig:RightHandIndex1").transform;
        ballPrefab.GetComponent<Rigidbody>().useGravity = false;
        ballPrefab.GetComponent<Transform>().parent = rightHand.parent;  
    }

    void moveBallToFirst()
    {
        rightHand = GameObject.Find("mixamorig:RightHandThumb1").transform;
        ballPrefab.transform.position = GameObject.Find("mixamorig:RightHandIndex1").transform.position - aVector;
        ballPrefab.GetComponent<Transform>().parent = rightHand.parent;
        ballPrefab.GetComponent<Rigidbody>().useGravity = false;
    }
}
