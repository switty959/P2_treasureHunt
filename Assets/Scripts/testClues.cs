using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testClues : MonoBehaviour
{
    public GameObject currentPage;
    public GameObject placeHolder;
    public GameObject nameholders;
    public GameObject ARPage;
    public GameObject arpageRiddle;

    public GameObject[] buttons;
    public GameObject[] rewards; // place 3D models in here
    public Vector2[] cluesCoordinates;
    public string[] cluesRiddle = { "who shot the sherrif?", "Who carry a teddy bear in online game called 'League of Legeonds'?", "Which movie is this reference from", "in the 'monty python and the holy grail', what is Tim's job?", "this spell is what?" };
    Transform imageHolder;
    public ARTapToPlaceObject setObject;
    public updateGPSText setTargetcoordinates;
    public Sprite[] buttonImage; // 0 is locked, 1 is checked

    public string currentPageName = "Canvas";
    public string cluesNames ="clue";
   
    public int numbersOfClues = 5;
    public int margin = 50;
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
            listOfClues[i] = new clues();
            int n = i + 1;
            string newClueName = cluesNames + n.ToString();
            listOfClues[i].setClueName(newClueName);
            listOfClues[i].setClueId(i);
            listOfClues[i].setClueHuntId(0);
            listOfClues[i].setClueRiddle(cluesRiddle[i]);
            listOfClues[i].setObjectToShow(rewards[i]);
            listOfClues[i].setClueCoordinates(cluesCoordinates[i]);
            
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
                nameholders.GetComponent<Button>().onClick.AddListener(delegate { headToARPage(clueId); });
                buttons[i] = newPlaceHolder;
                imageHolder = newPlaceHolder.transform.GetChild(1);
            }
            else
            {
                Debug.Log("no id was picked");
            }
        }
    }
    public void boolChange(int id)
    {
        listOfClues[id+1].setClueFound(true);
        listOfClues[id].setClueFound(false);
        listOfClues[id].setClueFounded(true);
        cluesFoundSoFar++;
        setObject.counter = 0;
    }

    public void headToARPage(int id)
    {
        setObject.objectsToSpawn = listOfClues[id].getObjectToShow();
        ARPage.SetActive(true);
        ARPage.GetComponent<ARpageTest>().id = id;
        ARPage.GetComponent<ARpageTest>().maxNumberOfClues = listOfClues.Length-1;
        
        this.gameObject.SetActive(false);
        setTargetcoordinates.GetComponent<updateGPSText>().target = listOfClues[id].getClueCoordinates();
        arpageRiddle.GetComponent<Text>().text = listOfClues[id].getClueRiddle();
    }

    public void checkClueBool()
    {
        if (cluesFoundSoFar == 0)
        {
            listOfClues[0].setClueFound(true);
        }

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
            if (listOfClues[i].getClueFounded())
            {
                buttons[i].transform.GetChild(1).transform.GetChild(0).GetComponent<Image>().sprite = buttonImage[1];
            }
            else
            {
                buttons[i].transform.GetChild(1).transform.GetChild(0).GetComponent<Image>().sprite = buttonImage[0];
            }
        }
    }
}
