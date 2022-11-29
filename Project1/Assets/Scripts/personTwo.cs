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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void DangerIsOff()
    {
        treasureCanGet = 10;
        treasureCanLose = 0;
        Console.WriteLine("treasure is now normal");
    }

    public void DangerIsOn()
    {
        treasureCanGet = 20;
        treasureCanLose = 10;
        Console.WriteLine("treasure is now dangermode"); 
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


}
