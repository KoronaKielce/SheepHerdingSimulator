using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingInv : MonoBehaviour
{

    Vector3 mousePos;
    Vector3 mouse;
    public bool mouseHeld = false;
    private GameObject oldPos;
    private Camera cam;
    public bool leave = false;
    public bool leave2 = false;
    private GameObject otherOldPos;
    private GameObject secondInv;
    public float speed = 9f;
    private GameObject mainInv;
    bool okToMove = false;
    private GameObject Scene;
    bool touchingMain = false;
    bool touchingInv = false;
    public float Timer = 0;
    public GameObject player;
    public GameObject Inventory;
    public bool heldInInv;
    public GameObject Parent;
    public bool mouseUp;
    public float Timer2;
    public GameObject Chest;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        Inventory = GameObject.Find("inventory(main)");
        Chest = GameObject.Find("chest");

    }

    // Update is called once per frame
    void Update()
    {
        
        Parent = gameObject.transform.parent.gameObject;
       
        Parent.SendMessage("childClicked", heldInInv);
        print(gameObject.name + gameObject.transform.position);
        if(gameObject.tag == "mouseHeld")
        {
            player = GameObject.Find("player");
            player.BroadcastMessage("spawnMainItem", gameObject);
        }
        if (leave == false)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
        if (leave == true)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        if (mouseHeld == true)
        {
            gameObject.tag = "clicked";
            mouse = Input.mousePosition;
            mousePos = cam.ScreenToWorldPoint(mouse);
            transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
        if (mouseHeld == false && leave == false)
        {

            transform.position = Vector3.MoveTowards(transform.position, oldPos.transform.position, 5 * Time.deltaTime);


        }
        else if (mouseHeld == false && leave == true)
        {
            if (leave == true)
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                secondInv = GameObject.Find("inventory(main)");
                transform.parent = secondInv.transform;
                transform.position = Vector3.MoveTowards(transform.position, secondInv.transform.position, 5 * Time.deltaTime);

            }
            if (gameObject.transform.localPosition == new Vector3(0, 0, 0))
            {
               
                leave = false;
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
        /* else if (mouseHeld == false && leave2 == true)
         {
             if (leave2 == true)
             {
                 secondInv = GameObject.Find("inventory(secondary(1)");
                 //transform.parent = secondInv.transform;
                 transform.position = Vector3.MoveTowards(transform.position, secondInv.transform.position, 9 * Time.deltaTime);

             }
         }*/

        if(mouseUp == true)
        {
            Timer2 += Time.deltaTime;
            if(Timer2 > 0.14f)
            {
                Inventory.BroadcastMessage("MouseState", mouseHeld);
                Chest.BroadcastMessage("MouseState", mouseHeld);
                Timer2 = 0;
                mouseUp = false;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            
            mouseHeld = false;
            heldInInv = false;
            mouseUp = true;
            
        }

    }
    public void OnMouseDown()
    {
        
        print(gameObject.transform.parent.name + "jjf");
        if(gameObject.transform.parent.name == "inventory(1st)")
        {
            heldInInv = true;
        }
        mouseHeld = true;
        Inventory.BroadcastMessage("MouseState", mouseHeld);
        Chest.BroadcastMessage("MouseState", mouseHeld);
        print("worksssssss!");  
    }
    public void OnTriggerStay2D(Collider2D other)
    {
       
        if (mouseHeld == false)
        {
            if (other.gameObject.tag == "inventory(1st)" || other.gameObject.tag == "inventory(2nd)" || other.gameObject.tag == "inventory(3rd)" || other.gameObject.tag == "inventory(4th)" || other.gameObject.tag == "mainInv" || other.gameObject.tag == "chestInventory")
            {
                transform.parent = other.gameObject.transform;
                oldPos = other.gameObject;
            }

        }
        if (mouseHeld == false)
        {

            if (other.gameObject.tag == "mainInv")
            {
                print("works");
                gameObject.tag = "mouseHeld";
                leave = false;




            }
            if (other.gameObject.tag == "itemsininventory(1st)" || other.gameObject.tag == "itemsininventory(2nd)" || other.gameObject.tag == "itemsininventory(3rd)"|| other.gameObject.tag == "itemsininventory(4th)")
            {

                gameObject.tag = "mouseHeld";
            }
            if (other.gameObject.tag == "inventory(1st)")
            {
                Timer += Time.deltaTime;
                if (Timer > 0.075f)
                {
                  
                    gameObject.tag = "itemsininventory(1st)";
                    Timer = 0;
                   
                }
            }
            if (other.gameObject.tag == "inventory(2nd)")
            {
                Timer += Time.deltaTime;
                if (Timer > 0.075f)
                {

                    gameObject.tag = "itemsininventory(2nd)";
                    Timer = 0;

                }
            }
            if (other.gameObject.tag == "inventory(3rd)")
            {
                Timer += Time.deltaTime;
                if (Timer > 0.075f)
                {

                    gameObject.tag = "itemsininventory(3rd)";
                    Timer = 0;

                }
            }
            if (other.gameObject.tag == "inventory(4th)")
            {
                Timer += Time.deltaTime;
                if (Timer > 0.075f)
                {

                    gameObject.tag = "itemsininventory(4th)";
                    Timer = 0;

                }
            }

            if (other.gameObject.tag == "chestInventory")
            {
                Timer += Time.deltaTime;
                if (Timer > 0.075f)
                {
                    gameObject.tag = "itemsInChest";
                    Inventory.SendMessage("ItemDeleted", this.gameObject.name);
                   
                    Timer = 0;

                }
            }
        }
        if (mouseHeld == false)
        {
            
                if (other.gameObject.tag == "mouseHeld" && gameObject.tag == "itemsininventory(1st)" || other.gameObject.tag == "mouseHeld" && gameObject.tag == "itemsininventory(2nd)" || other.gameObject.tag == "mouseHeld" && gameObject.tag == "itemsininventory(3rd)" || other.gameObject.tag == "mouseHeld" && gameObject.tag == "itemsininventory(4th)")
                {

                    Debug.Log("yes");
                   

                    leave = true;
                   
                }
            
            /* if (other.gameObject.tag == "itemsininventory" && gameObject.tag == "mouseHeld")
              {

                  Debug.Log("yes");
                  otherOldPos = other.gameObject;

                  leave2 = true;

              }*/
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {

    }


}