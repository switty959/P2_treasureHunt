using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class clueAnimation : MonoBehaviour
{

    public GameObject model;
    public GameObject scroll;

    public AnimationClip Closed;
    public AnimationClip Opening;
    public AnimationClip Open;

    public AnimationClip ScrollClosed;
    public AnimationClip ScrollOpening;
    public AnimationClip ScrollOpen;

    Animation scrollAnim;
    Animation modelAnim;


    private void Start()
    {
        scrollAnim = scroll.GetComponent<Animation>();
        modelAnim = model.GetComponent<Animation>();
     
    }

    private void Update()
    {


        if (Input.GetKeyDown("1"))
        {

           
           scrollAnim.Play(Opening.name.ToString());
            modelAnim.Play(ScrollOpening.name.ToString());
            

        }

    }
}