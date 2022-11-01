using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class textManager : MonoBehaviour
{

    //all of the text 
    public GameObject turnCounterObject;
    public GameObject deathCounterObject;
    public GameObject treasureCounterObject;
    public GameObject dangerTextObject;
    public GameObject resetTextObject;

    private TextMeshProUGUI turnCounter { get; set; }
    private TextMeshProUGUI deathCounter { get; set; }
    private TextMeshProUGUI treasureCounter { get; set; }
    private TextMeshProUGUI dangerText { get; set; }
    private TextMeshProUGUI resetText { get; set; }

    //some float or something of the turns thing
    private float turns;
    private float deaths;
    private float treasure;


    // Start is called before the first frame update
    void Start()
    {
        turnCounter = turnCounterObject.GetComponent<TextMeshProUGUI>();
        deathCounter = deathCounterObject.GetComponent<TextMeshProUGUI>();
        treasureCounter = treasureCounterObject.GetComponent<TextMeshProUGUI>();
        dangerText = dangerTextObject.GetComponent<TextMeshProUGUI>();
        resetText = resetTextObject.GetComponent<TextMeshProUGUI>();

        CalculateTurn();
    }

    // Update is called once per frame
    void Update()
    {
        turnCounter.text = "Turns: " + turns.ToString();
        deathCounter.text = "Deaths: " + deaths.ToString();
        treasureCounter.text = "Treasure Gained: " + treasure.ToString();
        if(GetComponent<DangerButtonManager>().isDanger == true)
        {
            dangerText.text = "Danger Mode: On";
        }else
        {
            dangerText.text = "Danger Mode: Off";
        }

        if(GetComponent<person>().gameEnd == true)
        {
            resetText.text = "Game Over. Click anywhere to continue.";
        }else
        {
            resetText.text = "Click buttons to gain treasure.";
        }

        CalculateTurn();
    }

    private void CalculateTurn()
    {
        //calls to stuff in the person class and checks if anything changed
        turns = GetComponent<person>().buttonCounter;
        deaths = GetComponent<person>().failCounter;
        treasure = GetComponent<person>().treasureGot;
    }
}

