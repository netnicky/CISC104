using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class person : MonoBehaviour
{
    //the total treasure 
    public float treasureGot = 0;

    //the chance of failure each turn and the number of failures
    public int failNumber;
    public float failCounter = 0;

    //the player buttons and the number of turns
    public Button personOneButton;
    public Button personTwoButton;
    public Button personThreeButton;

    public float buttonCounter = 0;

    //win bool
    public bool gameEnd;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = personOneButton.GetComponent<Button>();
        Button btn2 = personTwoButton.GetComponent<Button>();
        Button btn3 = personThreeButton.GetComponent<Button>();
        btn.onClick.AddListener(() => ButtonClick(personOneButton));
        btn2.onClick.AddListener(() => ButtonClick(personTwoButton));
        btn3.onClick.AddListener(() => ButtonClick(personThreeButton));
    }

    // Update is called once per frame
    void Update()
    {
        if (treasureGot == 100)
        {
            gameEnd = true;
            if (Input.GetMouseButtonDown (0))
            {
                treasureGot = 0;
                failCounter = 0;
                buttonCounter = 0;
                gameEnd = false;
            }
        }
        //locks the buttons when you treasure is at 100, unlocks them when 
        if (gameEnd == true)
        {
            personOneButton.interactable = false;
            personTwoButton.interactable = false;
            personThreeButton.interactable = false;
        }else
        {
            personOneButton.interactable = true;
            personTwoButton.interactable = true;
            personThreeButton.interactable = true;
        }
    }

    //the function of each button
    void ButtonClick(Button buttonPressed)
    {
        buttonCounter++;
        failNumber = Random.Range(0, 101);
        if (buttonPressed == personOneButton)
        {
            if(failNumber <= 70)
            {
                if(GetComponent<DangerButtonManager>().isDanger == true)
                {
                    if (treasureGot >= 90)
                    {
                        treasureGot = 100;
                    }else
                    {
                        treasureGot += 10;
                    }
                   
                }else
                {
                    if (treasureGot >= 95)
                    {
                        treasureGot = 100;
                    }else
                    {
                        treasureGot += 5;
                    }
                }
            }else
            {
                failCounter++;
                if (GetComponent<DangerButtonManager>().isDanger == true)
                {
                 if(treasureGot >= 5)
                    {
                        treasureGot -= 5;
                    }else
                    {
                        treasureGot = 0;
                    }
                }
            }
            
        }
        if (buttonPressed == personTwoButton)
        {
            if (failNumber <= 50)
            {
                if (GetComponent<DangerButtonManager>().isDanger == true)
                {
                    if (treasureGot >= 88)
                    {
                        treasureGot = 100;
                    }else
                    {
                        treasureGot += 12;
                    }
                }
                else
                {
                    if (treasureGot >= 93)
                    {
                        treasureGot = 100;
                    }else
                    {
                        treasureGot += 7;
                    }
                }
            }else
            {
                failCounter++;
                if(GetComponent<DangerButtonManager>().isDanger == true)
                {
                    if(treasureGot >= 7)
                    {
                        treasureGot -= 7;
                    }else
                    {
                        treasureGot = 0;
                    }
                }
            }
        }
        if (buttonPressed == personThreeButton)
        {
            if(failNumber <= 30)
            {
                if (GetComponent<DangerButtonManager>().isDanger == true)
                {
                    if (treasureGot >= 85)
                    {
                        treasureGot = 100;
                    }else
                    {
                        treasureGot += 15;
                    }
                }
                else
                {
                    if (treasureGot >= 90)
                    {
                        treasureGot = 100;
                    }else
                    {
                        treasureGot += 10;
                    }
                }
            }else
            {
                failCounter++;
                if(GetComponent<DangerButtonManager>().isDanger == true)
                {
                    if(treasureGot >= 10)
                    {
                        treasureGot -= 10;
                    }else
                    {
                        treasureGot = 0;
                    }
                }
            }
        }
        
    }

  
}
