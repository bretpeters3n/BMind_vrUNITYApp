using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int index;
    public string levelName;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //if(other.CompareTag("Player"))
        //{
        SceneManager.LoadScene(index);
        //}
    }
}
