using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//use this script

public class SceneHandler : MonoBehaviour
{
    [SerializeField] private string newDemoScene; //make public?
    public void OpenDemoScene()
    {
        SceneManager.LoadScene(newDemoScene); //scene 0
    }

    //
    //"VR_Room A&C2 - Throwing Beanbag - Age Band 1" is Scene 0 /newDemoScene
}

