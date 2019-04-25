using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject close;
    public bool open;

    public void openMenu()
    {

        menu.GetComponent<Animation>().Play("Info_Menu_Open");
        open = true;
        close.SetActive(true);

    }

    public void closeMenu() {

        menu.GetComponent<Animation>().Play("Info_Menu_Close");
        open = false;
        close.SetActive(false);

    }
    
}
