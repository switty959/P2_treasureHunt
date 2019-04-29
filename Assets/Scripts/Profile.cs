using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profile {
    //data field 
    private string name;
    private int age;

    private int score = 0;
    private float distance = 0;
    private double totaltime = 0;
    private int completed_hunts = 0;
    private int currenthunt_id;

    //constructor
 public Profile(string name) {
        this.name = name;
    }
    public Profile()
    {

    }

    //getters and setters

        //name
     public string getName() {
        return name;
    }

    public void setName(string name) { 
        this.name = name;
    }
         //age
    public int getAge()
    {
        return this.age;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

         //score
    public int getScore()
    {
        return this.score;
    }

    public void setScore(int score)
    {
        this.score = score;
    }

         //distance
    public float getDistance()
    {
        return this.distance;
    }

    public void setDistance(float distance)
    {
        this.distance = distance;
    }
         //totaltime
    public double getTotalTime()
    {
        return this.totaltime;
    }

    public void setTotaltime(double totaltime)
    {
        this.totaltime = totaltime;
    }
         //completed_hunts
    public int getCompletedHunts()
    {
        return this.completed_hunts;
    }
 
    public void setCompletedHunts(int completed_hunts)
    {
        this.completed_hunts = completed_hunts;
    }
           //currenthunt_id
    public int getCurrenthunt_id ()
    {
        return this.currenthunt_id;
    }

    public void setCurrenthunt_id(int currenthunt_id)
    {
        this.currenthunt_id = currenthunt_id;
    }

    //display?? --> done through unity?


}
