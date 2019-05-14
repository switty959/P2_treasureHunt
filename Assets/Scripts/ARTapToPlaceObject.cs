using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using System;

public class ARTapToPlaceObject : MonoBehaviour
{
    public GameObject placementIndicator;
    public GameObject objectsToSpawn;
    
    private ARSessionOrigin arOrigin;
    private Pose placemantPose;
    public bool placementPoseIsValid = false;
    ARpageTest idchecker;
    public updateGPSText counterCheck;
    public bool isObjectPlaced = false;
    

    // Start is called before the first frame update
    void Start()
    {
        arOrigin = FindObjectOfType<ARSessionOrigin>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlacementPose();
        UpdatePlacementIndicator();
        Vector2 newPos = new Vector2(TestLocationService.Instance.latitude, TestLocationService.Instance.longtitude);

        if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !isObjectPlaced && Vector2.Distance(newPos, counterCheck.target) <= counterCheck.howFar)
        {
            PlaceObject();
            

        }
    }

    public void PlaceObject()
    {
        Instantiate(objectsToSpawn, placemantPose.position, placemantPose.rotation);
        counterCheck.counter = true;
        isObjectPlaced = true;

    }

    private void UpdatePlacementIndicator()
    {
        if (placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(placemantPose.position, placemantPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false);
        }
    }

    private void UpdatePlacementPose()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        arOrigin.Raycast(screenCenter,hits,TrackableType.Planes);

        placementPoseIsValid = hits.Count > 0;

        if (placementPoseIsValid)
        {
            placemantPose = hits[0].pose;

            var cameraForward = Camera.current.transform.forward;
            var cameraBearing = new Vector3(cameraForward.x,0,cameraForward.z).normalized;

            placemantPose.rotation = Quaternion.LookRotation(cameraBearing);
        }
    }
   
}
