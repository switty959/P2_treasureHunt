using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideThisObject : MonoBehaviour
{
    public Navigation navi;

    // Update is called once per frame
    void Update()
    {
        if (navi.Panels[7].activeSelf == true)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}
