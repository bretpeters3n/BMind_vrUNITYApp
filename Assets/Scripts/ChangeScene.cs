using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string levelName;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(levelName);
    }
}