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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


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
        treasureCanGet += 15;
        treasureCanLose += 15;
    }
}
