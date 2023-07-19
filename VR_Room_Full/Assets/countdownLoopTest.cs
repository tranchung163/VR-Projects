using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UIElements;

public class countdownLoopTest : MonoBehaviour
{
    public float totalTime = 30; // Total countdown time in seconds
    private float currentTime; // Current countdown time
    public TextMeshProUGUI timeText;
    public bool showTime = false;

    private IEnumerator Start()
    {
        showTime = true;
        // Start the countdown timer
        yield return StartCoroutine(StartTimer());

        // Loop the countdown timer
        while (true)
        {
            //yield return new WaitForSeconds(1f);
            yield return StartCoroutine(StartTimer());
        }
    }

    private IEnumerator StartTimer()
    {
        if (totalTime > 0)
        {
            yield return null;
            totalTime -= Time.deltaTime;
        
            timeText.text = totalTime.ToString("F0");
        }
        else
        {
            totalTime = 0;
            showTime = false;

            yield return new WaitForSeconds(3f);

            totalTime = 30;
            showTime = true;
        }

        // DisplayTime(totalTime);
    }

    
}
