using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip on;
    public AudioClip off;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playOn()
    {
        audio.PlayOneShot(on);
    }

    public void playOff()
    {
        audio.PlayOneShot(off);
    }

}
