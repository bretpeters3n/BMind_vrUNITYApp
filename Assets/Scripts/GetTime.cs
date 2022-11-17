using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GetTime : MonoBehaviour
{
    public TMPro.TextMeshProUGUI time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime currentTime = DateTime.Now;

        string hour = LeadingZero(currentTime.Hour);
        string minute = LeadingZero(currentTime.Minute);

        time.text = hour + ":" + minute;
    }

    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
