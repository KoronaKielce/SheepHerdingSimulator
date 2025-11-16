using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial_YesButtonClick : MonoBehaviour
{
    public int clicks = 0;
    public GameObject Tutorial_Button;
    public string message;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {

        if (clicks == 0)
        {
            
            Tutorial_Button.SendMessage("yesButton_Clicked");
        }
    }
}
