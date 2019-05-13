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
    public Text[] textOnEndPage;//0 is for score, 1 is for distance and 2 is for time 

    

    public void goToClue()
    {
            testclues.boolChange(id);
            backToClues.SetActive(true);
            currentPage.SetActive(false);
            endPage.SetActive(false);
    }

    public void goToEnd()
    {
        backToClues.SetActive(false);
        currentPage.SetActive(false);
        endPage.SetActive(true);
        
        textOnEndPage[2].text = timer.GetComponent<timer>().minutes+" : "+timer.GetComponent<timer>().seconds;
        timer.enabled = false;
    }
    public void checkIdmatch()
    {
        if (id < maxNumberOfClues || cluefound.cluesFoundSoFar <maxNumberOfClues)
        {
            backButtons[0].gameObject.SetActive(true);
            backButtons[1].gameObject.SetActive(false);
        }

        else
        {
            backButtons[0].gameObject.SetActive(false);
            backButtons[1].gameObject.SetActive(true);
        }
    }
}
