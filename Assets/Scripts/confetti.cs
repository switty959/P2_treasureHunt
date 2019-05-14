using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confetti : MonoBehaviour
{
    public GameObject Confetti;
    private bool played;
    private void Start()
    {
        Confetti.GetComponent<ParticleSystem>().Stop();
        played = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("1") && played == false || Input.touchCount == 1 && played == false)
        {
           
            Confetti.GetComponent<ParticleSystem>().Play();
            played = true;

        }
    }

   
}
