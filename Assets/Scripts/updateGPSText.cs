using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateGPSText : MonoBehaviour
{
    public Vector2 target;
    public float howFar;
    public int checkpoint;
    public GameObject arpageShowRiddle;

    private void Start()
    {
        Vector2 newPos = new Vector2(TestLocationService.Instance.latitude, TestLocationService.Instance.longtitude);

    }
    // Update is called once per frame
    void Update()
    {

        Vector2 newPos = new Vector2 (TestLocationService.Instance.latitude, TestLocationService.Instance.longtitude);
        
        if (Vector2.Distance(newPos, target) <= howFar)
        {
            arpageShowRiddle.SetActive(false);
            Handheld.Vibrate();
        }
        else
        {
            arpageShowRiddle.SetActive(true);
        }
        
    }
    

    

}
