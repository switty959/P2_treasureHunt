using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testHunt : MonoBehaviour
{
    public GameObject canvasHolder;
    public GameObject placeHolder;
    public GameObject nameholders;
    public string canvasName = "Canvas";
    public string[] huntNames = {"yes i did sir","have you seen my bear, tibbers","biggus dickus"," i go by many name, but you can call me tim","Lighting bolt!" };
    public int numbersOfHunts = 5;
    int margin = 50;
    
    public hunt[] hunters = new hunt[5];
    
    // Start is called before the first frame update
    void Start()
    {
        canvasHolder = GameObject.Find(canvasName);
        Debug.Log(numbersOfHunts.ToString());
        generateHunts();
        
    }

   public void generateHunts()
    {
        for (int i = 0; i < hunters.Length; i++)
        {
            hunters[i] = new hunt();
            hunters[i].setHuntName(huntNames[i]);
            GameObject newPlaceHolder = Instantiate(placeHolder, canvasHolder.transform);
            Vector3 newPosition = newPlaceHolder.transform.position;
            newPosition.y = newPosition.y - (margin * i);
            newPlaceHolder.transform.position = newPosition; 
            nameholders = placeHolder.transform.GetChild(0).gameObject;
            hunters[i].getHuntName(nameholders);
        }
    }
}
