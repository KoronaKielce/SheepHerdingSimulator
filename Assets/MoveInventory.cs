using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInventory : MonoBehaviour
{
    Vector3 mouse;
    bool mouseHeld = false;
    public bool touchingOther = false;
    private Camera cam;
    public Vector3 mousePos;
    public Vector3 mainInvPos = new Vector3(-21.58211f, 7.1f, 0);
    GameObject oldPos;
    public float speed = 200f;
    private GameObject secondInv;
    private Transform secondInvTrans;
    bool goToSecondInv = false;
    private GameObject otherObjectOldPos;
    bool Leave = false;
    public GameObject otherOldPos;
    public GameObject player;
    public GameObject main;
    float once = 0;
    // Start is called before the first frame update
    void Start()
    {

        cam = Camera.main;
        oldPos.transform.position = gameObject.transform.position;
        print(oldPos);
        secondInv = GameObject.Find("inventory(main)");
       
        secondInvTrans = secondInv.transform;

    }

    // Update is called once per frame
    void Update()
    {
       
        if (gameObject.tag == "mouseHeld") { 
        if (mouseHeld == true)
        {
            mouse = Input.mousePosition;
            mousePos = cam.ScreenToWorldPoint(mouse);
            transform.position = new Vector3(mousePos.x, mousePos.y, 0);



        }
        if (mouseHeld == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, oldPos.transform.position, 7 * Time.deltaTime);
                
            }
           

            if (Input.GetMouseButtonUp(0))
        {
            mouseHeld = false;
        }


            
        }
        if (Leave == true)
        {
            if (mouseHeld == true)
            {
                Debug.Log("works");
                secondInv = GameObject.Find("inventory(main)");
                otherOldPos.transform.position = Vector3.MoveTowards(otherOldPos.transform.position, secondInv.transform.position, 1 * Time.deltaTime);


                Debug.Log(otherOldPos.name);
                //Leave = true;
            }
            else
            {
                otherOldPos.tag = "mouseHeld";
                this.gameObject.tag = "itemsininventory";
            }
            
            
            
        }
    }
    public void OnMouseDown()
    {
        
     mouseHeld = true;
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "inventory")
        {
            oldPos = other.gameObject;

            goToSecondInv = true;
        }
        if(other.gameObject.tag == "itemsininventory")
           
        {
            otherOldPos = other.gameObject;
            Leave = true;
           // other.gameObject.BroadcastMessage("MoveToOther", this.gameObject);
            
            
            
            
               // touchingOther = true;
            
        }
           
        
    }
    public void MoveToOther(GameObject otherOldPos)
    {
        if (mouseHeld == true)
        {
            Debug.Log("works");
            secondInv = GameObject.Find("inventory(main)");
            otherOldPos.transform.position = Vector3.MoveTowards(otherOldPos.transform.position, secondInv.transform.position, 7 * Time.deltaTime);
           

            Debug.Log(otherOldPos.name);
            //Leave = true;
        }
        else
        {
            otherOldPos.tag = "mouseHeld";
            gameObject.tag = "itemsininventory";
        }
     
    }
    public void ok()
    {
        
        {
            Debug.Log(oldPos.transform.position);
           
           
        }
        
    }
       
        
            
        
       
    }

