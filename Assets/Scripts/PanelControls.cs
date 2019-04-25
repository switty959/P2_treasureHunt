using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PanelControls : MonoBehaviour
{

    public GameObject PanelToOpen;
    public GameObject PanelToClose;
    public bool active;


    public void openPanel()
    {
        if (PanelToOpen != null && active == true)
        {

            PanelToClose.SetActive(false);

            PanelToOpen.SetActive(true);

        }
    }

    public void fader()
    {


    }

}

  


