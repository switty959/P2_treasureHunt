using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testClues : MonoBehaviour
{
    public GameObject currentPage;
    public GameObject placeHolder;
    public GameObject nameholders;
    public GameObject[] buttons;
    Transform imageHolder;

    public string currentPageName = "Canvas";
    public string cluesNames ="clue";
    public string[] cluesRiddle = { "who shot the sherrif?", "Who carry a teddy bear in online game called 'League of Legeonds'?", "Which movie is this reference from", "in the 'monty python and the holy grail', what is Tim's job?", "this spell is what?" };
    public int numbersOfClues = 5;
    int margin = 50;
    public int fk_hunt_id;
    public int cluesFoundSoFar = 0;

    public clues[] listOfClues;
    // Start is called before the first frame update
    void Start()
    { 
        currentPage = GameObject.Find(currentPageName);
        listOfClues = new clues[numbersOfClues];
        buttons = new GameObject[numbersOfClues];
        generateClues();
        
    }
    private void Update()
    {
        checkClueBool();
    }


    public void generateClues()
    {

        for (int i = 0; i < numbersOfClues; i++)
        {
            Debug.Log(fk_hunt_id);
            listOfClues[i] = new clues();
            int n = i + 1;
            string newClueName = cluesNames + n.ToString();
            listOfClues[i].setClueName(newClueName);
            listOfClues[i].setClueId(i);
            listOfClues[i].setClueHuntId(1);
            listOfClues[i].setClueRiddle(cluesRiddle[i]);
            
        }
        for (int i = 0; i < numbersOfClues; i++)
        {
            if (listOfClues[i].getClueHuntId() == fk_hunt_id)
            {
                int clueId = listOfClues[i].getClueId();
                GameObject newPlaceHolder = Instantiate(placeHolder, currentPage.transform);
                Vector3 newPosition = newPlaceHolder.transform.position;
                newPosition.y = newPosition.y - (margin * i);
                newPlaceHolder.transform.position = newPosition;
                nameholders = newPlaceHolder.transform.GetChild(0).gameObject;
                listOfClues[i].getClueName(nameholders);
                nameholders.GetComponent<Button>().onClick.AddListener(delegate { test(clueId); });
                buttons[i] = newPlaceHolder;
                imageHolder = newPlaceHolder.transform.GetChild(1);
            }
            else
            {
                Debug.Log("no id was picked");
            }
        }
    }
    public void test(int id)
    {
        Debug.Log(listOfClues[id].getClueRiddle());
        listOfClues[id + 1].setClueFound(true);
    }
    public void checkClueBool()
    {
        listOfClues[0].setClueFound(true);
        for (int i = 0; i < numbersOfClues; i++)
        {
            //buttons[i].SetActive(false);
            
            if (listOfClues[i].getClueFound())
            {

                buttons[i].transform.GetChild(1).gameObject.SetActive(false);
            }
            else
            {
                buttons[i].transform.GetChild(1).gameObject.SetActive(true);
            }
           
        }
    }
}
