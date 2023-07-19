using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
    
{
    public string nextScene;

    [SerializeField] private string newDemoScene = "VR_Room - A&C2 - Throwing Beanbag - Age Band 1";

    public void LoadScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    //
    //"VR_Room A&C2 - Throwing Beanbag - Age Band 1" is Scene 0
}

