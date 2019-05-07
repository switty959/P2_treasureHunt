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
   
    Animator modelAnim;


    private void Start()
    {
        
        modelAnim = model.GetComponent<Animator>();
     
    }

    private void Update()
    {


        if (Input.GetKeyDown("1"))
        {          
          
            modelAnim.Play(Opening.name.ToString());
            
        }

    }
}