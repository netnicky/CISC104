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

    public void NewGame()
    {
        PersonOneScore = 0;
        fails = 0;
        DangerIsOff();
    }

    //these are all for the tests so the tests can run
    public float GetCanGet()
    {
        return treasureCanGet;
    }

    public float GetCanLose()
    {
        return treasureCanLose;
    }

    public float GetScore()
    {
        return PersonOneScore;
    }

    public float GetFails()
    {
        return fails;
    }

    public float GetRate()
    {
        return successRate;
    }
}
