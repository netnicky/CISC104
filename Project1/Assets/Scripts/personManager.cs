using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class personManager : MonoBehaviour
{
    //for the peoples
    private personOne personOne;
    private personTwo personTwo;
    private personThree personThree;

    //the buttons
    public Button personOneButton;
    public Button personTwoButton;
    public Button personThreeButton;
    public Button dangerButton;

    //the turns and fails and total treasure
    public int turns = 0;
    public int fails = 0;
    public int totalTreasure = 0;

    //the bools
    public bool gameOver = false;

    public bool isDanger = false;

    //for the text
    public GameObject turnCounterObject;
    public GameObject failCounterObject;
    public GameObject treasureCounterObject;
    public GameObject dangerTextObject;
    public GameObject resetTextObject;

    private TextMeshProUGUI turnCounter { get; set; }
    private TextMeshProUGUI failCounter { get; set; }
    private TextMeshProUGUI treasureCounter { get; set; }
    private TextMeshProUGUI dangerText { get; set; }
    private TextMeshProUGUI resetText { get; set; }



    //start
    void Start()
    {
        turnCounter = turnCounterObject.GetComponent<TextMeshProUGUI>();
        failCounter = failCounterObject.GetComponent<TextMeshProUGUI>();
        treasureCounter = treasureCounterObject.GetComponent<TextMeshProUGUI>();
        dangerText = dangerTextObject.GetComponent<TextMeshProUGUI>();
        resetText = resetTextObject.GetComponent<TextMeshProUGUI>();

        personOne = new personOne();
        personTwo = new personTwo();
        personThree = new personThree();
    }


    void Update()
    {
        turnCounter.text = "Turns: " + turns.ToString();
        failCounter.text = "Fails: " + fails.ToString();
        treasureCounter.text = "Treasure Gained: " + totalTreasure.ToString();
        if (isDanger == true)
        {
            dangerText.text = "Danger Mode: On";
        }
        else
        {
            dangerText.text = "Danger Mode: Off";
        }

        if (gameOver == true)
        {
            resetText.text = "Game Over. Click any button to reset.";
        }
        else
        {
            resetText.text = "Click buttons to gain treasure.";
        }
    }


    public void PersonOneClicked()
    {
        if(gameOver == false)
        {
            personOne.AttemptToGetTreasure();

            turns++;

            RoundOver();
        }else
        {
            NewGame();
        }
    }

    public void PersonTwoClicked()
    {
        if(gameOver == false)
        {
            personTwo.AttemptToGetTreasure();

            turns++;

            RoundOver();
        }else
        {
            NewGame();
        }
    }

    public void PersonThreeClicked()
    {
        if(gameOver == false)
        {
            personThree.AttemptToGetTreasure();

            turns++;

            RoundOver();
        }else
        {
            NewGame();
        }
    }

    public void DangerClick()
    {
        if(gameOver == false)
        {
            isDanger = !isDanger;

            if (isDanger == true)
            {
                personOne.DangerIsOn();
                personTwo.DangerIsOn();
                personThree.DangerIsOn();
            }
            else
            {
                personOne.DangerIsOff();
                personTwo.DangerIsOff();
                personThree.DangerIsOff();
            }
        }else
        {
            NewGame();
        }
    }

    public void RoundOver()
    {
        totalTreasure = personOne.PersonOneScore + personTwo.personTwoScore + personThree.personThreeScore;
        fails = personOne.fails + personTwo.fails + personThree.fails;
        CheckScores();
    }

    public void CheckScores()
    {
        //it checks if the turns equals a certain number or if the fails equals a certain number and if so it will run the game over
        if(turns == 60 || fails == 20)
        {
            gameOver = true;
        }
    }

    public void NewGame()
    {
        gameOver = false;
        isDanger = false;
        turns = 0;
        fails = 0;
        totalTreasure = 0;
        personOne.NewGame();
        personTwo.NewGame();
        personThree.NewGame();
    }

}
