using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testHunt : MonoBehaviour
{
    public GameObject canvasHolder;
    public GameObject placeHolder;
    public GameObject nameholders;
    string canvasName = "Canvas";
    string[] huntNames = {"yes i did sir","have you seen my bear, tibbers" };
    Vector3 margin = new Vector3(0,0,50);
    
    hunt[] hunters = new hunt[2];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < hunters.Length; i++)
        {
            hunters[i] = new hunt();
            hunters[i].setHuntName(huntNames[i]);
            canvasHolder = GameObject.Find(canvasName);
            GameObject newPlaceHolder = Instantiate(placeHolder, canvasHolder.transform );
            nameholders = placeHolder.transform.GetChild(0).gameObject;
            hunters[i].getHuntName(nameholders);
        }
        
        
    }

   
}
