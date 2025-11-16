using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectPlayer_Tutorial : MonoBehaviour
{
    public Text _text;
    public bool messageClicked = false;
    public GameObject Tutorial;
    public bool onDoor = false;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
            if (onDoor == true)
            {
                if (Input.GetKey("e"))
                {
                print("worksssssssr");
                    Tutorial.SendMessage("entered_shop");
                      Destroy(this.gameObject);
                }
            }
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == ("player"))
        {

           
            if (messageClicked == true)
            {
                _text.text = "Great! Now get close to the door of the shop and click 'E' to enter";
                onDoor = true;
            }
        }
    }
    public void Message2()
    {
        messageClicked = true;
    }
    }
