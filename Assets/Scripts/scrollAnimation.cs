using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class scrollAnimation : MonoBehaviour
{

   
    public GameObject scroll;

    public AnimationClip ScrollClosed;
    public AnimationClip ScrollOpening;
    public AnimationClip ScrollOpen;

    Animation scrollAnim;
    


    private void Start()
    {
        scrollAnim = scroll.GetComponent<Animation>();
        

    }

    private void Update()
    {


        if (Input.GetKeyDown("1"))
        {

            scrollAnim.Play(ScrollOpening.name.ToString());

        }

    }
}