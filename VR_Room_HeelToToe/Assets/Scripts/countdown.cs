using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class countdown : MonoBehaviour
{
    public float timeValue = 30;
    public TextMeshProUGUI timeText;
    public bool showTime = false;

    void Start()
    {
       // invoke("Update", 5); //5 sec delay
        showTime = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (showTime)
        {

            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;
                showTime = false;
            }

            DisplayTime(timeValue);
        }


        

    }


    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
       
        
        timeText.text = timeToDisplay.ToString("F0");
    }
//timer,ajselection, amyselection, beanbagthrow/throw beanbag!!, beanbag stop
}
