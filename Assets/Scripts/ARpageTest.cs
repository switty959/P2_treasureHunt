using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARpageTest : MonoBehaviour
{
    public GameObject backToClues;
    public GameObject currentPage;
    public GameObject endPage;

    public testClues testclues;
    public Button[] backButtons;
    public int id;
    public int maxNumberOfClues;
    public timer timer;
    public testClues cluefound;
    public updateGPSText boolCheck;
    public ARTapToPlaceObject objectCheck;
    public Text[] textOnEndPage;//0 is for score, 1 is for distance and 2 is for time 
    public Text boolChecker;
    public GameObject naviBar;

    private void Update()
    {
        boolChecker.text = "object placed : " + objectCheck.isObjectPlaced;
    }

    public void goToClue()
    {
        if (cluefound.cluesFoundSoFar == cluefound.numbersOfClues - 1 && boolCheck.counter)
        {
            backToClues.SetActive(false);
            currentPage.SetActive(false);
            endPage.SetActive(true);
            objectCheck.isObjectPlaced = false;
            textOnEndPage[2].text = timer.GetComponent<timer>().minutes + " : " + timer.GetComponent<timer>().seconds;
            timer.enabled = false;
            boolCheck.counter = false;
            naviBar.SetActive(true);
        }

        if (id< cluefound.numbersOfClues && boolCheck.counter)
        {
            testclues.boolChange(id);
            backToClues.SetActive(true);
            currentPage.SetActive(false);
            endPage.SetActive(false);
            objectCheck.isObjectPlaced = false;

        }    
    }

   
}
