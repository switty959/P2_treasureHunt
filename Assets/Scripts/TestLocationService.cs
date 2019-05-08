using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLocationService : MonoBehaviour
{
    public float latitude, longtitude;
    public static TestLocationService Instance { set; get; }

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(StartLocationService());
    }

    private IEnumerator StartLocationService()
    {
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("user has not enabled gps");
            yield break;
        }
        Input.location.Start(1,0.1f);
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait >0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        if (maxWait <= 0)
        {
            Debug.Log("Timed out");
            yield break;
        }
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to dermin deivce location");
            yield break;
        }
        latitude = Input.location.lastData.latitude;
        longtitude = Input.location.lastData.longitude;
        yield break;
    }
    private void Update()
    {
        latitude = Input.location.lastData.latitude;
        longtitude = Input.location.lastData.longitude;
    }
}
