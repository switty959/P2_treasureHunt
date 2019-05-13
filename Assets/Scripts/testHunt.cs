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
    public string[] huntNames = {"Harbour Hunt","Stoneage Rampage, Dickhead Dinosaurs","Prostitutes of the Pyramids"," Indianna Jones and the Temple of Sydhavn","Harbour Hunt" };
    public int numbersOfHunts = 1;
    public int margin = 50;
    
    public hunt[] hunters;
    public timer timer;
    
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
        this.gameObject.SetActive(false);
        cluePage.SetActive(true);
        cluePage.GetComponent<testClues>().fk_hunt_id = id;
        timer.enabled = true;

    }
   
}
