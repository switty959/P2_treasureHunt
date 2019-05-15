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
    public int id;
    public int maxNumberOfClues;
    public timer timer;
    public testClues cluefound;
    public updateGPSText boolCheck;
    public ARTapToPlaceObject objectCheck;
    public Text[] textOnEndPage;//0 is for score, 1 is for distance and 2 is for time 
    public GameObject naviBar;


    public void goToClue()
    {
        if (cluefound.cluesFoundSoFar == cluefound.numbersOfClues - 1 && boolCheck.counter)
        {
            backToClues.SetActive(false);
            currentPage.SetActive(false);
            endPage.SetActive(true);
            objectCheck.isObjectPlaced = false;
            int minutes = int.Parse(timer.minutes);
            int sec = int.Parse(timer.seconds);
            float distance = 547;

            float score = minutes*0.5f+sec+0.3f+distance*0.4f;
            
            textOnEndPage[0].text = score.ToString();
            textOnEndPage[1].text = distance.ToString()+" m";
            textOnEndPage[2].text = timer.GetComponent<timer>().minutes + " : " + timer.GetComponent<timer>().seconds;
            timer.enabled = false;
            boolCheck.counter = false;
            naviBar.SetActive(true);
            
        }

        if (id< cluefound.numbersOfClues && boolCheck.counter)
        {
            cluefound.showHint.gameObject.SetActive(false);
            testclues.boolChange(id);
            backToClues.SetActive(true);
            currentPage.SetActive(false);
            endPage.SetActive(false);
            objectCheck.isObjectPlaced = false;

        }
        
    }
    public void showHint()
    {
        cluefound.showHint.gameObject.SetActive(true);
    }


}
