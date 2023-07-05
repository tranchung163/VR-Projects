using UnityEngine;

public class StopHopping : MonoBehaviour
{
    public GameObject walker;

    float startTime;
    float endTime;
    Vector3 firstPosition = new Vector3(1.4f, 0f, -0.06f);
    Vector3 diffPos = new Vector3(0f, 0f, 0.002f);


    // Start is called before the first frame update
    private void Start()
    {
        startTime = 0f;
        endTime = 10.2f;
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        if (startTime >= endTime)
        {
            Debug.Log("Again");
            walker.transform.position = firstPosition;
            startTime = 0f;

        }

    }
}