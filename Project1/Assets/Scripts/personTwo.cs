using System.Collections;
using System.Collections.Generic;
using System;

public class personTwo
{
    private int treasureCanGet = 10;
    private int treasureCanLose = 0;
    private float successRate = 50;

    public int personTwoScore = 0;
    public int fails = 0;


    public void DangerIsOff()
    {
        treasureCanGet = 10;
        treasureCanLose = 0;
    }

    public void DangerIsOn()
    {
        treasureCanGet = 20;
        treasureCanLose = 10;
    }

    public void AttemptToGetTreasure()
    {
        Random rng = new Random();
        int failNumber = rng.Next(100);

        if (failNumber <= successRate)
        {
            personTwoScore += treasureCanGet;
        }
        else
        {
            personTwoScore -= treasureCanLose;
            fails++;
        }
    }

    public void NewGame()
    {
        personTwoScore = 0;
        fails = 0;
        DangerIsOff();
    }

}
