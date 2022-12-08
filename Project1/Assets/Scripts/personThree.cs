using System.Collections;
using System.Collections.Generic;
using System;

public class personThree
{
    private int treasureCanGet = 15;
    private int treasureCanLose = 0;
    private float successRate = 30;

    public int personThreeScore = 0;
    public int fails = 0;


    public void AttemptToGetTreasure()
    {
        Random rng = new Random();
        int failNumber = rng.Next(100);

        if (failNumber <= successRate)
        {
            personThreeScore += treasureCanGet;
        }
        else
        {
            personThreeScore -= treasureCanLose;
            fails++;
        }
    }

    public void DangerIsOff()
    {
        treasureCanGet = 15;
        treasureCanLose = 0;
    }

    public void DangerIsOn()
    {
        treasureCanGet = 30;
        treasureCanLose = 15;
    }

    public void NewGame()
    {
        personThreeScore = 0;
        fails = 0;
        DangerIsOff();
    }

}
