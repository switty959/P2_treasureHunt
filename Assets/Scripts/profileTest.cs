using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class profileTest : MonoBehaviour
{
    public GameObject profileName, profileScore, profileDistance, profileTotalTime, profileHuntsCompleted;

    void Start()
    {

        Profile profile = new Profile("bob bobsen");


        profileName.GetComponent<Text>().text = profile.getName();
        profileScore.GetComponent<Text>().text = profile.getScore().ToString();
        profileDistance.GetComponent<Text>().text = profile.getDistance().ToString() + " km";
        profileTotalTime.GetComponent<Text>().text = profile.getTotalTime().ToString();
        profileHuntsCompleted.GetComponent<Text>().text = profile.getCompletedHunts().ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
