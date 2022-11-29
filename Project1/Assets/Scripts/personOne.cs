using System.Collections;
using System.Collections.Generic;
using System;

public class personOne
{
    //priv floats that store treasure each person can steal or lose and success rate they have
    private int treasureCanGet = 5;
    private int treasureCanLose = 0;
    private float successRate = 70;

    public int PersonOneScore = 0;
    public int fails = 0;

    //game stuff idk if it belongs in this class or whatever
    //nvm it doesnt belong in here it belongs in the other class
    //basically theres a new game function that sets all the floats of the turn numbers to 0, turns the danger button off, and enables button clicks.

    //do a set score thing that the manager can access?


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    //this is how the thing works
    public void AttemptToGetTreasure()
    {
        Random rng = new Random();
        int failNumber = rng.Next(100);

        if (failNumber <= successRate)
        {
            PersonOneScore += treasureCanGet;
        }
        else
        {
            PersonOneScore -= treasureCanLose;
            fails++;
        }
    }

    public void DangerIsOff()
    {
        treasureCanGet = 5;
        treasureCanLose = 0;
    }

    public void DangerIsOn()
    {
        treasureCanGet = 10;
        treasureCanLose = 5;
    }

}
