using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class clueAnimation : MonoBehaviour
{

    public GameObject model;
    
    public AnimationClip Closed;
    public AnimationClip Opening;
    public AnimationClip Open;
    private bool Played;
   
    Animator modelAnim;


    private void Start()
    {
        
        modelAnim = model.GetComponent<Animator>();
     
    }

    private void Update()
    {


        if (Input.GetKeyDown("1") && Played == false || Input.touchCount == 1 && Played == false)
        {          
          
            modelAnim.Play(Opening.name.ToString());
            Played = true;
        }

    }
}