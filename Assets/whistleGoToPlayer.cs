using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whistleGoToPlayer : MonoBehaviour
{
    public SpriteRenderer rend;
    public GameObject sheepSpawn;
    public GameObject whistleFace;
    public bool whistling = false;
    public float Timer;
    public float timesClicked = 0;
    public GameObject Dialogue;
    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        rend.color = new Color(255, 255, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (whistling == true)
        {
           
            whistleFace.SetActive(true);
            Timer += Time.deltaTime;
            sheepSpawn.BroadcastMessage("goToPlayer");
            if (Timer > 5f) //3 is the time parameter for how long player cant whistle again and whistling animation can play
            {
                whistleFace.SetActive(false);
                Timer = 0;
                whistling = false;
            }
        }
    }
    public void OnMouseOver()
    {
        rend.color = new Color(255, 255, 255, 255);
    }
    public void OnMouseExit()
    {
        rend.color = new Color(255, 255, 255, 0);
    }
    public void OnMouseDown()
    {

        if (whistling == false)
        {
            timesClicked++;
            if(timesClicked == 1)
            {
                Dialogue.SendMessage("whistleButton_Clicked");
            }
            whistling = true;
            
        }
       
        
       
    }
}
