using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testHunt : MonoBehaviour
{
    public GameObject canvasHolder;
    public GameObject placeHolder;
    public GameObject nameholders;
    public GameObject cluePage;


    public string canvasName = "Canvas";
    public string[] huntNames = {"yes i did sir","have you seen my bear, tibbers","biggus dickus"," i go by many name, but you can call me tim","Lighting bolt!" };
    public int numbersOfHunts = 1;
    int margin = 50;
    
    public hunt[] hunters;
    
    // Start is called before the first frame update
    void Start()
    {

        canvasHolder = GameObject.Find(canvasName);
        
        
        hunters = new hunt[numbersOfHunts];
        generateHunts();
    }
   
    public void generateHunts()
    {
        for (int i = 0; i < numbersOfHunts; i++)
        {
            hunters[i] = new hunt();
            hunters[i].setHuntName(huntNames[i]);
            hunters[i].setHuntId(i);
            int huntId = hunters[i].getHuntId();
            GameObject newPlaceHolder = Instantiate(placeHolder, canvasHolder.transform);
            Vector3 newPosition = newPlaceHolder.transform.position;
            newPosition.y = newPosition.y - (margin * i);
            newPlaceHolder.transform.position = newPosition; 
            nameholders = newPlaceHolder.transform.GetChild(0).gameObject;
            hunters[i].getHuntName(nameholders);
            nameholders.GetComponent<Button>().onClick.AddListener(delegate { goToCluePage(huntId); });
        }
       
    }

    public void goToCluePage(int id)
    {
        canvasHolder.SetActive(false);
        cluePage.SetActive(true);
        cluePage.GetComponent<testClues>().fk_hunt_id = id;
        Debug.Log(id.ToString());
    }
}
