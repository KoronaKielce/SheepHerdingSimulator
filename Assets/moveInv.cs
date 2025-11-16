using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveInv : MonoBehaviour
{
    Vector3 mousePos;
    Vector3 mouse;
    public bool mouseHeld = false;
    private GameObject oldPos;
    private Camera cam;
    public bool leave = false;
    private GameObject otherOldPos;
    private GameObject secondInv;
    public float speed = 9f;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
     
    }

    // Update is called once per frame
    void Update()
    {
        
        if (mouseHeld == true)
        {
            mouse = Input.mousePosition;
            mousePos = cam.ScreenToWorldPoint(mouse);
            transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
        if (mouseHeld == false && leave == false)
        {

            transform.position = Vector3.MoveTowards(transform.position, oldPos.transform.position, speed * Time.deltaTime);

           
        }
        else  if (mouseHeld == false && leave == true)
            {
            if (gameObject.tag == "itemsininventory")
            {
                Debug.Log("worls");
                secondInv = GameObject.Find("inventory(main)");
                transform.position = Vector3.MoveTowards(transform.position, secondInv.transform.position, 9 * Time.deltaTime);
                otherOldPos.tag = "itemsininventory";
                if(transform.position == secondInv.transform.position)
                {
                    leave = false;
                }
            }
            }
        
        if (Input.GetMouseButtonUp(0))
        {
            mouseHeld = false;
                leave = true;
        }
     /*   if(leave == true)
        {
            if (mouseHeld == true)
            {
                Debug.Log(otherOldPos.name);
                secondInv = GameObject.Find("inventory(main)");
                oldPos = secondInv;
                //otherOldPos.transform.position = Vector3.MoveTowards(otherOldPos.transform.position, secondInv.transform.position, speed * Time.deltaTime);
            } 
           
        }*/
    }

    public void OnMouseDown()
    {
        mouseHeld = true;   
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        if (mouseHeld == false)
        {
            if (other.gameObject.tag == "mainInv" && transform.position == other.gameObject.transform.position)
            {
                gameObject.tag = "mouseHeld";
            }
            if (other.gameObject.tag == "inventory" || other.gameObject.tag == "mainInv")
            {

                oldPos = other.gameObject;
            }
            if (other.gameObject.tag == "inventory")
            {
                
                this.gameObject.tag = "itemsininventory";
               
            }
        }
        
        
    
    
            if (other.gameObject.tag == "mouseHeld")
            {
                
                otherOldPos = other.gameObject;
                leave = true;
            }
        
        }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (mouseHeld == true)
        {
           gameObject.tag = null;
        }
            leave = false;
        
    }
}
