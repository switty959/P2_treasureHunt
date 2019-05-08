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

    private void Update()
    {
        if (id < maxNumberOfClues)
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

    public void goToClue()
    {
            testclues.test(id);
            backToClues.SetActive(true);
            currentPage.SetActive(false);
            endPage.SetActive(false);
    }

    public void goToEnd()
    {
        backToClues.SetActive(false);
        currentPage.SetActive(false);
        endPage.SetActive(true);
    }
}
