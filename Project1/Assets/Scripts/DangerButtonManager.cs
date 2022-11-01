using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DangerButtonManager : MonoBehaviour
{
    //reference the danger button
    public Button dangerButton;

    //will i need a bool to check if its on or off?

    public bool isDanger;


    // Start is called before the first frame update
    void Start()
    {
        Button dbtn = dangerButton.GetComponent<Button>();
        dbtn.onClick.AddListener(() => DangerClick(dangerButton));
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<person>().gameEnd == true)
        {
            dangerButton.interactable = false;
        }else
        {
            dangerButton.interactable = true;
        }
    }

    void DangerClick(Button buttonPressed)
    {
        isDanger = !isDanger;
    }

}
