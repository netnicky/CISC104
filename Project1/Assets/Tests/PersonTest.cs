using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PersonTest
{
    // Tests if everything is 0 upon starting
    [Test]
    public void PersonConstructorTest()
    {
        //setup
        person newPerson = new person();

        //Assert
        Assert.AreEqual(0, newPerson.treasureGot);
        Assert.AreEqual(0, newPerson.failCounter);
        Assert.AreEqual(0, newPerson.buttonCounter);
    }





    //tests if buttons lock when game ends or at least it should
    [Test]
    public void ButtonLockTest()
    {
        //set up
        person newPerson = new person();

        //act, sets that to 100 so the buttons lock
        newPerson.treasureGot = 100;

        //assert if the buttons are locked
        Assert.IsTrue(newPerson.personOneButton.interactable == false);
        Assert.IsTrue(newPerson.personTwoButton.interactable == false);
        Assert.IsTrue(newPerson.personThreeButton.interactable == false);

    }



}
