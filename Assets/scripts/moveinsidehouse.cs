using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveinsidehouse : MonoBehaviour
{
    public float Timer;
    public bool time = false;
    public bool timeon = false;
    bool time2 = false;
    bool timeon2 = false;
    public GameObject trans;
    public GameObject cam;
    public GameObject player;
    public int leaveCounter = 0;
    public int enterCounter = 0;
    public GameObject Dialogue;
    // Start is called before the first frame update
    void Start()
    {
           

    }

    // Update is called once per frame
    void Update()
    {
        
    if(leaveCounter == 1)
        {
            Dialogue.SendMessage("Leaving_House");
            leaveCounter = 2;
        }
    if(enterCounter == 1)
        {
            
                Dialogue.SendMessage("In_House");
            enterCounter = 2;
            
        }
    if(enterCounter == 3)
        {
            Dialogue.SendMessage("In_House_To_Cook");
            enterCounter = 4;
        }
    if(leaveCounter == 3)
        {
            Dialogue.SendMessage("Leaving_House_For_Sheep");
            leaveCounter = 4;
        }
       if (time == true)
        {
            if (Input.GetKeyDown("e"))
            {
                timeon = true;
                enterCounter++;
               
            }
         
        }
       
        if (timeon == true)
        {
            trans.SendMessage("starttrans");
            cam.SendMessage("intohouse");
            player.SendMessage("intohouse");
            Timer += Time.deltaTime;

            if (Timer > 1f)
            {
             
                transform.position = new Vector3(0, -12.95f, 0);
                    timeon = false;
                    time = false;
                Timer = 0;
                }
            }

        if (time2 == true)
        {
            if (Input.GetKeyDown("e"))
            {
                leaveCounter++;
                timeon2 = true;
                

            }
        }
        if (timeon2 == true)
        {
            
            trans.SendMessage("starttrans");
            cam.SendMessage("outofhouse");
            player.SendMessage("outofhouse");
            Timer += Time.deltaTime;

            if (Timer > 1f)
            {
                
                transform.position = new Vector3(-3.77999f, -1.84f, 0);
                timeon2 = false;
                time2 = false;
                Timer = 0;
            }
        }



    }
     public void OnTriggerEnter2D(Collider2D other)
{
        
            if (other.gameObject.name == ("layer 1"))
            {
            

            time = true;

            }
           
      
        if (other.gameObject.name == ("door"))
        {
           
            time2 = true;
        }
        }
    public void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.name == ("layer 1"))
        {


            time = false;

        }
       

        if (other.gameObject.name == ("door"))
        {

            time2 = false;
        }
    }


}


