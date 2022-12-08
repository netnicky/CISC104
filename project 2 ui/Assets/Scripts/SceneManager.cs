using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SceneManager : MonoBehaviour
{
    //for all of the text
    public GameObject opponentScoreText;
    public GameObject playerScoreText;
    public GameObject opponentHandText;
    public GameObject playerHandText;
    public GameObject opponentTotalText;
    public GameObject playerTotalText;
    public GameObject winTextObject;

    //for the buttons
    public Button hitButton;
    public Button holdButton;
    public Button newRoundButton; //this is to deal the cards after the round happens if needed

    //variables. I used them for the lines that set the text. Change them if needed.
    public int opponentScoreNumber = 0;
    public int playerScoreNumber = 0;
    public int opponentHandTotal = 0;
    public int playerHandTotal = 0;


    //for the text
    private TextMeshProUGUI opponentScore { get; set; }
    private TextMeshProUGUI playerScore { get; set; }
    private TextMeshProUGUI opponentHand { get; set; }
    private TextMeshProUGUI playerHand { get; set; }
    private TextMeshProUGUI opponentTotal { get; set; }
    private TextMeshProUGUI playerTotal { get; set; }
    private TextMeshProUGUI winText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        opponentScore = opponentScoreText.GetComponent<TextMeshProUGUI>();
        playerScore = playerScoreText.GetComponent<TextMeshProUGUI>();
        opponentHand = opponentHandText.GetComponent<TextMeshProUGUI>();
        playerHand = playerHandText.GetComponent<TextMeshProUGUI>();
        opponentTotal = opponentTotalText.GetComponent<TextMeshProUGUI>();
        playerTotal = playerTotalText.GetComponent<TextMeshProUGUI>();
        winText = winTextObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        opponentScore.text = "Opponent Score: " + opponentScoreNumber.ToString();
        playerScore.text = "Your Score: " + playerScoreNumber.ToString();
        opponentHand.text = "Opponent's Hand"; //this text does not change
        playerHand.text = "Your Hand"; //this text does not change
        opponentTotal.text = "Total: " + opponentHandTotal.ToString(); 
        playerTotal.text = "Total: " + playerHandTotal.ToString();

        //displays who won. displays nothing if nobody won. This code is not complete, I made it to show what the text should say.
        if (playerHandTotal >= 21 && opponentHandTotal <= 21)
        {
            winText.text = "Opponent Wins!";
        }
        else if (playerHandTotal <= 21 && opponentHandTotal >= 21)
        {
            winText.text = "You Win!";
        }else
        {
            winText.text = " ";
        }

    }
}
