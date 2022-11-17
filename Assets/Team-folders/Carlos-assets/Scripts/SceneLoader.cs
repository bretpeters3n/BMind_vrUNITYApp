using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //Could be used to start the scene
    public string nextScene;

 
    public void LoadScene()
    {
        SceneManager.LoadScene(nextScene);
    }

}
