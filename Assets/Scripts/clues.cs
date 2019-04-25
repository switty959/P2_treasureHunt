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
    double latX;
    double longY;
    bool clueFound;

    public clues()
    {
        name = "first clue";
        riddles = "this is a riddle";
        id = 0;
        fk_huntId = 0;
        latX = 0.0;
        longY = 0.0;
        clueFound = false;
    }
    public clues (string tempName, string tempRiddle, int tempId, int tempHuntId, double tempLatX, double tempLongY)
    {
        name = tempName;
        riddles = tempRiddle;
        id = tempId;
        fk_huntId = tempHuntId;
        latX = tempLatX;
        longY = tempLongY;
        clueFound = false;
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
    public double getClueLatX()
    {
        return this.latX;
    }
    public double getClueLongY()
    {
        return this.longY;
    }
    public bool getClueFound()
    {
        return this.clueFound;
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
    public void setClueLatX(double newLatX)
    {
        this.latX = newLatX;
    }
    public void setClueLongY(double newLongY)
    {
        this.longY = newLongY;
    }

    public void setClueFound(bool newBool)
    {
        this.clueFound = newBool;
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
    public void getClueLatX(GameObject textholder)
    {
        textholder.GetComponentInChildren<Text>().text = this.latX.ToString();
    }
    public void getClueLongY(GameObject textholder)
    {
        textholder.GetComponentInChildren<Text>().text = this.longY.ToString();
    }
    //custom get method ending
}
