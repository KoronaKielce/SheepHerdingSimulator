using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveinsideShop : MonoBehaviour
{
    public float Timer;
    bool time = false;
    bool timeon = false;
    bool time2 = false;
    bool timeon2 = false;
    public GameObject trans;
    public GameObject cam;
    public GameObject player;
    public bool dontExit = false;
    public int leaveCounter = 0;
    public int enterCounter = 0;
    public GameObject Dialogue;
    public Text _text;
    // Start is called before the first frame update
    void Start()
    {


    }

    public void BeginBlur()
    {
        dontExit = true;
    }
    public void EndBlur()
    {
        dontExit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(leaveCounter == 1)

        {
            Dialogue.SendMessage("Left_Shop");
            leaveCounter = 2;
            
        }
        if (enterCounter == 1)
        {
            Dialogue.SendMessage("entered_shop");
            enterCounter = 2;
        }
        if(enterCounter == 3)
        {
            Dialogue.SendMessage("entered_shop_For_Food");
            enterCounter = 4;


        }
        if(leaveCounter == 3)
        {
            Dialogue.SendMessage("Left_Shop_To_Cook");
            leaveCounter = 4;
        }
        if (time == true)
        {
            if (Input.GetKeyDown("e"))
            {
                enterCounter++;
                timeon = true;


            }
        }
        if (timeon == true)
        {
            trans.SendMessage("starttrans");
            cam.SendMessage("intoShop");
            player.SendMessage("intoShop");
            Timer += Time.deltaTime;

            if (Timer > 1f)
            {

                transform.position = new Vector3(26.009f, -12.73f, 0);
                timeon = false;
                time = false;
                Timer = 0;
            }
        }

        if (time2 == true)
        {
            if (Input.GetKeyDown("e"))
            {
                if (dontExit == false)
                {
                    leaveCounter++;
                    timeon2 = true;


                }else if (dontExit == true)
                {
                    leaveCounter++;
                    timeon2 = true;
                }
            }
            if (timeon2 == true)
            {
                trans.SendMessage("starttrans");
                cam.SendMessage("outOfShop");
                player.SendMessage("outOfShop");
                Timer += Time.deltaTime;

                if (Timer > 1f)
                {

                    transform.position = new Vector3(4.1f, -1.8f, 0);
                    timeon2 = false;
                    time2 = false;
                    Timer = 0;
                }
            }



        }
    }
        public void OnTriggerEnter2D(Collider2D other)
        {

            if (other.gameObject.name == ("ShopCollider"))
            {

            _text.text = "Great! Now get close to the door of the shop and click 'E' to enter";
            time = true;

            }

            if (other.gameObject.name == ("shop inside"))
            {

                time2 = true;
            }
        }
        public void OnTriggerExit2D(Collider2D other)
        {

            if (other.gameObject.name == ("ShopCollider"))
            {


                time = false;

            }

            if (other.gameObject.name == ("shop inside"))
            {

                time2 = false;
            }
        }


    
}


