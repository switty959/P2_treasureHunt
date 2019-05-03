using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InfoMenu : MonoBehaviour
{

    public GameObject menu;
    public Vector2 Start;
    public Vector2 End;

    void start()
    {
        gameObject.GetComponent<Transform>().position = Start;
    }

    public void animateMenu()
    {
        gameObject.GetComponent<Transform>().position = End;
    }

}