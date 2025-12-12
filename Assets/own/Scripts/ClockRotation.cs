using System;
using UnityEngine;

public class ClockRotation : MonoBehaviour
{

    public GameObject clockHour;
    public GameObject clockMinute;
    public GameObject clocSecond;

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;

        float SecondRotation = (time.Second + time.Millisecond/1000f) / 60f * 360;
        float MinuteRotation = time.Minute / 60f * 360 + SecondRotation/60;
        float HourRotation = time.Hour/12f*360 + MinuteRotation/60;

        clocSecond.transform.rotation = Quaternion.Euler(SecondRotation, 0f, 0f);
        clockMinute.transform.rotation = Quaternion.Euler(MinuteRotation, 0f, 0f);
        clockHour.transform.rotation = Quaternion.Euler(HourRotation, 0f,0f);
    }
}
