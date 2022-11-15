using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GetDate : MonoBehaviour
{
    public TMPro.TextMeshProUGUI date;
    public TMPro.TextMeshProUGUI time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime currentTime = DateTime.Now;
        int month = currentTime.Month;
        int day = currentTime.Day;
        int year = currentTime.Year;

        string hour = LeadingZero(currentTime.Hour);
        string minute = LeadingZero(currentTime.Minute);
        string second = LeadingZero(currentTime.Second);

        date.text = concatDate(month, day, year);
        time.text = hour + ":" + minute + ":" + second;
    }

    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }

    string concatDate(int month, int day, int year)
    {
        string monthString;

        switch(month)
        {
            case 1:
                monthString = "January";
                break;
            case 2:
                monthString = "February";
                break;
            case 3:
                monthString = "March";
                break;
            case 4:
                monthString = "April";
                break;
            case 5:
                monthString = "May";
                break;
            case 6:
                monthString = "June";
                break;
            case 7:
                monthString = "July";
                break;
            case 8:
                monthString = "August";
                break;
            case 9:
                monthString = "September";
                break;
            case 10:
                monthString = "October";
                break;
            case 11:
                monthString = "November";
                break;
            case 12:
                monthString = "December";
                break;
            default:
                monthString = "---";
                break;
        }

        return monthString + " " + day.ToString() + ", " + year.ToString();
    }
}
