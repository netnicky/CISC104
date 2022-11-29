using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DangerButtonManager : MonoBehaviour
{
    //reference the danger button
    public Button dangerButton;

    //reference the other classes 
    private personOne personOne;
    private personTwo personTwo;
    private personThree personThree;

    public bool isDanger = false;


    // Start is called before the first frame update
    void Start()
    {
        personOne = new personOne();
        personTwo = new personTwo();
        personThree = new personThree();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DangerClick()
    {
        isDanger = !isDanger;
        Console.WriteLine("danger switch");

        if(isDanger == true)
        {
            personOne.DangerIsOn();
            personTwo.DangerIsOn();
            personThree.DangerIsOn();
            Console.WriteLine("danger is on");

        }else
        {
            personOne.DangerIsOff();
            personTwo.DangerIsOff();
            personThree.DangerIsOff();
            Console.WriteLine("danger is off");
        }
        
    }

}
