using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_EnterHouse_Tutorial : MonoBehaviour
{
    public bool intoHouse = false;
    public float Timer = 0;
    public bool timerOn = false;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (intoHouse == true)
        {
            if (Input.GetKey("e"))
            {
                Button.SendMessage("In_House");


            }
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == ("player"))
        {

            intoHouse = true;


        }
    }
}
