using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public double startTime;
    public string minutes, seconds;
    private void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        trigger();       
    }

    void trigger()
    {
        float t = Time.time - (float)startTime;

        minutes = ((int)t / 60).ToString();
        seconds = (t % 60).ToString("N0");
    }
}
