using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFlip : MonoBehaviour
{
    public GameObject Button;
   




    public void flip() //Correct GPS location flip clue button to reveal AR button
    {

        
        Button.GetComponent<Animator>().SetTrigger("Flip");
        Handheld.Vibrate();
        

    }

    public void flipBack() //inCorrect GPS location flip clue button back

    { 
        Button.GetComponent<Animator>().SetTrigger("FlipBack");


    }


}

