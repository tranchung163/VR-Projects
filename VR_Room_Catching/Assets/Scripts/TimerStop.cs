
using UnityEngine;

public class TimerStop : MonoBehaviour
{
    public GameObject walker;
    bool stop = false;
    Animator animator;
    float startTime;
    float endTime;
    Vector3 endLine = new Vector3(-0.01621421f, -0.001583072f, 3.810499f); 

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        startTime = 0f;
        endTime = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        if (startTime >= endTime || walker.transform.position == endLine || GameObject.Find("Room_Modern").transform == walker.transform)
        {
            Debug.Log("Again");
            transform.position = new Vector3(0f, 0f, 0f);
            startTime = 0f;
       
        }

    }
}
