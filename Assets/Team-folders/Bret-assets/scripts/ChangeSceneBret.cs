using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneBret : MonoBehaviour
{
    public void MoveToScene(int sceneID)
    {
        Debug.Log("Clicked" + sceneID);
        SceneManager.LoadScene(sceneID);
    }
}
