using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour

{

    public GameObject BackButton;
    public GameObject[] Panels;
    public GameObject Info_Menu;
    public GameObject HomeBar;



    void Start()
    {
        int count = gameObject.transform.childCount-1;
        Panels = new GameObject[count];
        for (int i = 0; i < count; i++)
        {
            Panels[i] = gameObject.transform.GetChild(i).gameObject;
        }
        // Puts panels into array
    }

    private void Update()
    {
        if (Panels[1].activeInHierarchy)
        {
            BackButton.SetActive(false);
            HomeBar.SetActive(false);

        } // If on homepage set back button to inactive

        else
        {
            BackButton.SetActive(true);
            HomeBar.SetActive(true);
        }
         // If anywhere else but homepage set back button to active

    }
    public void back()
    {

        if (Panels[0].activeSelf)
        {
            Panels[6].SetActive(true);
            

            Panels[0].SetActive(false);
            Panels[1].SetActive(false);
            Panels[2].SetActive(false);
            Panels[3].SetActive(false);
            Panels[4].SetActive(false);
            Panels[5].SetActive(false);
            Panels[7].SetActive(false);
        } // if on ar cam page, back button sets clue page to active and deactivates the rest

       
        else if (Panels[6].activeInHierarchy)
        {
            Panels[5].SetActive(true);
            

            Panels[0].SetActive(false);
            Panels[1].SetActive(false);
            Panels[2].SetActive(false);
            Panels[3].SetActive(false);
            Panels[4].SetActive(false);
            Panels[6].SetActive(false);
            Panels[7].SetActive(false);
        } // if on clues page, back button sets hunts page to active and deactivates the rest

        else 
        {
            Panels[1].SetActive(true);
            

            Panels[0].SetActive(false);
            Panels[7].SetActive(false);
            Panels[2].SetActive(false);
            Panels[3].SetActive(false);
            Panels[4].SetActive(false);
            Panels[5].SetActive(false);
            Panels[6].SetActive(false);
        } // if on any other page, back button sets homepage to active and deactivates the rest



    }

}
