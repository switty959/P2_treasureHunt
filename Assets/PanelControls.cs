using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelControls : MonoBehaviour {

    public GameObject PanelToOpen;
    public GameObject PanelToClose;
    

    public void openPanel()
    {
        if (PanelToOpen != null)
            PanelToOpen.SetActive(true);
        PanelToClose.SetActive(false);

           
    }

  

}
