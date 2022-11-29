using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class personManager : MonoBehaviour
{
    //person person = new person
    //set up buttons how they are set up in project 2 THEY MUST BE SET UP IN THIS BC ITS MONOBEHAVIOUR
    //button1 on click does like this
    //step1 run a priv void that gets the number to beat and then checks if the person failed or not 
    //step2 if succ, add the person1 treasure (the person class checks if the db is on, so the proper treasure will be added
    //step2b if fail, add the person1 penalty (will be 0 if the db is off)

    //i want it to be round based and potentially have a high score thing but idk how to implement that. 
    //when the rounds = 50 or the fails = 20, the game ends

    //for idk the peoples
    private personOne personOne;
    private personTwo personTwo;
    private personThree personThree;


    //the buttons
    public Button personOneButton;
    public Button personTwoButton;
    public Button personThreeButton;

    //the turns and fails
    public int turns = 0;
    public int fails = 0;

    public int totalTreasure = 0;

    //an int that's value will be the person one score but idk the best way to do this

    public bool gameOver = false;

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
        if (GetComponent<DangerButtonManager>().isDanger == true)
        {
            dangerText.text = "Danger Mode: On";
        }
        else
        {
            dangerText.text = "Danger Mode: Off";
        }

        if (gameOver == true)
        {
            resetText.text = "Game Over. Click anywhere to continue.";
        }
        else
        {
            resetText.text = "Click buttons to gain treasure.";
        }
    }


    public void PersonOneClicked()
    {
        personOne.AttemptToGetTreasure();

        turns++;

        RoundOver();
    }

    public void PersonTwoClicked()
    {
        personTwo.AttemptToGetTreasure();

        turns++;

        RoundOver();
    }

    public void PersonThreeClicked()
    {
        personThree.AttemptToGetTreasure();

        turns++;

        RoundOver();
    }


    public void RoundOver()
    {
        totalTreasure = personOne.PersonOneScore + personTwo.personTwoScore + personThree.personThreeScore;
        fails = personOne.fails + personTwo.fails + personThree.fails;
        //something about calculating the total treasure by adding up the individual scores
        //calculating the fails?
    }

    public void GameOver()
    {

    }

}
