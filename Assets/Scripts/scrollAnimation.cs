﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class scrollAnimation : MonoBehaviour
{

   
    public GameObject scroll;

    public AnimationClip ScrollClosed;
    public AnimationClip ScrollOpening;
    public AnimationClip ScrollOpen;
    private bool Played;

    Animation scrollAnim;
    


    private void Start()
    {
        scrollAnim = scroll.GetComponent<Animation>();
        

    }

    private void Update()
    {


        if (Input.GetKeyDown("1") && Played == false || Input.touchCount == 1 && Played == false)
        {

            scrollAnim.Play(ScrollOpening.name.ToString());
            Played = true;

        }

    }
}