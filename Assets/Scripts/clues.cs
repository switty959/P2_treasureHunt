using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class clues
{
    string name;
    string riddles;
    int id;
    int fk_huntId;
    Vector2 coordinates;
    bool clueFound;
    bool clueFounded;
    GameObject objectToShow;

    public clues()
    {
        name = "first clue";
        riddles = "this is a riddle";
        id = 0;
        fk_huntId = 0;
        coordinates = new Vector2(0,0);
        clueFound = false;
        clueFounded = false;
    }
    public clues (string tempName, string tempRiddle, int tempId, int tempHuntId, float tempLatX, float tempLongY,GameObject tempObject)
    {
        name = tempName;
        riddles = tempRiddle;
        id = tempId;
        fk_huntId = tempHuntId;
        coordinates = new Vector2(tempLatX, tempLongY);
        clueFound = false;
        clueFounded = false;
        objectToShow = tempObject;
    }
    //standard get method start
    public string getClueName()
    {
        return this.name;
    }
    public string getClueRiddle()
    {
        return this.riddles;
    }
    public int getClueId()
    {
        return this.id;
    }
    public int getClueHuntId()
    {
        return this.fk_huntId;
    }

    public Vector2 getClueCoordinates()
    {
        return this.coordinates;
    }

    public bool getClueFound()
    {
        return this.clueFound;
    }

    public bool getClueFounded()
    {
        return this.clueFounded;
    }

    public GameObject getObjectToShow()
    {
        return this.objectToShow;
    }
    // standard get methods ends

    // standard set method starting
    public void setClueName(string newName)
    {
        this.name = newName;
    }
    public void setClueRiddle(string newRiddle)
    {
        this.riddles = newRiddle;
    }
    public void setClueId(int newId)
    {
        this.id = newId;
    }
    public void setClueHuntId(int newHuntId)
    {
        this.fk_huntId = newHuntId;
    }
    public void setClueCoordinates(float newLatX, float newLongY)
    {
        this.coordinates = new Vector2(newLatX,newLongY);
    }
    public void setClueCoordinates(Vector2 newCoordinates)
    {
        this.coordinates = newCoordinates;
    }
    public void setClueFound(bool newBool)
    {
        this.clueFound = newBool;
    }

    public void setClueFounded(bool newBool)
    {
        this.clueFounded = newBool;
    }

    public void setObjectToShow(GameObject newObject)
    {
        this.objectToShow = newObject;
    }
    // standard set method ending

    // custom get method starting
    public void getClueName(GameObject textholder)
    {
        textholder.GetComponentInChildren<Text>().text = this.name;
    }
    public void getClueRiddle(GameObject textholder)
    {
        textholder.GetComponentInChildren<Text>().text = this.riddles;
    }
    public void getClueId(GameObject textholder)
    {
        textholder.GetComponentInChildren<Text>().text = this.id.ToString();
    }
    public void getClueHuntId(GameObject textholder)
    {
        textholder.GetComponentInChildren<Text>().text = this.fk_huntId.ToString();
    }
    
    //custom get method ending

   
}
