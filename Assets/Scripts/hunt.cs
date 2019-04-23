using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

   
    public class hunt
    {
        string name;
        int id;
        int score;
        double time;
        float distance;

        public hunt()
        {
            name = "Did someone order a knuckle sandwich?";
            id = 0;
            score = 0;
            time = 0;
            distance = 0;

        }
        public hunt(string tempName)
        {
            name = tempName;
            id = 0;
            score = 0;
            time = 0;
            distance = 0;
        }

        public string getHuntName()
        {
        return this.name;
        }
        public void getHuntName(GameObject textHolder)
        {
            textHolder.GetComponent<Text>().text = this.name;
        }
        public void getHuntScore(GameObject textHolder)
        {
            textHolder.GetComponent<Text>().text = this.score.ToString();
        }
        public void getHuntTime(GameObject textHolder)
        {
            textHolder.GetComponent<Text>().text = this.time.ToString();
        }
        public void getHuntDistance(GameObject textHolder)
        {
            textHolder.GetComponent<Text>().text = this.distance.ToString();
        }
        public void setHuntName(string newName)
        {
            this.name = newName;
        }
}
    
