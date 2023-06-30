using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    [SerializeField] private string newDemoScene = "VR_Room - A&C2 - Throwing Beanbag - Age Band 1";
    public void OpenDemoScene()
    {
        SceneManager.LoadScene(0);
    }

    //
    //"VR_Room A&C2 - Throwing Beanbag - Age Band 1" is Scene 0
}

