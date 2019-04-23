using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour

{

    public GameObject BackButton;
    public GameObject[] Panels;


    // Start is called before the first frame update
    void Start()
    {
        int count = gameObject.transform.GetChildCount()-1;
        Panels = new GameObject[count];
        for (int i = 0; i < count; i++)
        {
            Panels[i] = gameObject.transform.GetChild(i).gameObject;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
