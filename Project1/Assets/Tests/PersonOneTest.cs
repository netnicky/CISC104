using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PersonOneTest
{
    //test if the person sets up right
    [Test]
    public void PersonOneSetUp()
    {
        //setup and act
        personOne newPersonOne = new personOne();

        //assert
        Assert.AreEqual(0, newPersonOne.GetScore());
        Assert.AreEqual(0, newPersonOne.GetFails());
        Assert.AreEqual(5, newPersonOne.GetCanGet());
        Assert.AreEqual(0, newPersonOne.GetCanLose());
        Assert.AreEqual(70, newPersonOne.GetRate());

    }

    //test if the person gets treasure correctly 
    [Test]
    public void GetTreasureTest()
    {
        //setup
        personOne newPersonOne = new personOne();

        //act
        for (int i = 0; i < 100; i++) //this is enough times for it to not be 0 probably
        {
            newPersonOne.AttemptToGetTreasure();
        }

        //assert
        Assert.AreNotEqual(0, newPersonOne.GetScore());
        Assert.AreNotEqual(0, newPersonOne.GetFails());
    }

    //test if the dangerison works properly
    [Test]
    public void DangerIsOnTest()
    {
        //setup
        personOne newPersonOne = new personOne();

        //act
        newPersonOne.DangerIsOn();

        //assert
        Assert.AreEqual(10, newPersonOne.GetCanGet());
        Assert.AreEqual(5, newPersonOne.GetCanLose());

    }

    //test if the dangerisoff works properly after the dangerison happens
    [Test]
    public void DangerIsOffTest()
    {
        //setup
        personOne newPersonOne = new personOne();

        //act
        newPersonOne.DangerIsOn();
        newPersonOne.DangerIsOff();

        //assert
        Assert.AreEqual(5, newPersonOne.GetCanGet());
        Assert.AreEqual(0, newPersonOne.GetCanLose());
    }


    //test if the person resets properly 
    [Test]
    public void ResetPersonTest()
    {
        //set up
        personOne newPersonOne = new personOne();

        //act
        newPersonOne.DangerIsOn(); //turn on the danger so i can make sure the newgame is resetting the treasurecanlose value too

        for (int i = 0; i < 20; i++) //runs through it 20 times
        {
            newPersonOne.AttemptToGetTreasure();
        }

        newPersonOne.NewGame();

        //assert
        Assert.AreEqual(0, newPersonOne.GetScore());
        Assert.AreEqual(0, newPersonOne.GetFails());
        Assert.AreEqual(5, newPersonOne.GetCanGet());
        Assert.AreEqual(0, newPersonOne.GetCanLose());
    }
}
