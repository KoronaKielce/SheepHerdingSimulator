using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeDialogue : MonoBehaviour
{
    public Text _text;
    public int clicks;
    public GameObject square;
    public bool inShop = false;
    public SpriteRenderer Dialogue_Box;
    public SpriteRenderer Dialogue_Button;
    public Sprite ShopKeeper_Dialogue;
    public Sprite Sheep_Dialogue;
    public float Timer;
    public GameObject Contract;
    public GameObject whitesquare;
    public Sprite Button;
    public GameObject pencil;
    public bool afterContract = false;
    public GameObject flashlightHighlight;
    public bool afterFlashlightClick = false;
    public GameObject yesButtonHighlight;
    public bool afterYesButtonClicked = false;
    public bool quickCheck = false;
    public BoxCollider2D collide;
    public bool inHouse = false;
    public bool wakeUp = false;
    public bool leaveHouse = false;
    public bool leaveShop = false;
    public bool enterShopAgain = false;
    public GameObject energybarHighlight;
    public bool leaveShopAgain = false;
    public bool cookInHouse = false;
    public bool doneCooking = false;
    public bool mealInInv = false;
    public bool mealEaten = false;
    public bool openedCal = false;
    public bool leaveForSheep = false;
    public GameObject profileButtonHighlight;
    public bool gateOpen = false;
    public bool whistledForSheep = false;
    public bool closedCal = false;
    public bool tasksLook = false;
    public bool sheepLeavePen = false;
    public bool trailheadEnter = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // GameObject Item = GameObject.FindGameObjectsWithTag("itemsInChest");
        GameObject main_PlaceHolder = GameObject.FindGameObjectWithTag("mouseHeld");
        if(sheepLeavePen == true)
        {
            Dialogue_Box.sprite = Sheep_Dialogue;
            Dialogue_Button.sprite = Button;
            collide.enabled = true;
            _text.text = "Alright! now  move to the right in order to access the trailhead!";
            if(clicks == 1 || trailheadEnter == true)
            {
                _text.text = "If you made it this far, thank yo so much for playing my sneakpeek of SheepHerding Simmulator! Please enjoy exploring the rest of this game!";
            }
            if (clicks == 2)
            {

                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if(whistledForSheep == true)
        {
            Dialogue_Box.sprite = Sheep_Dialogue;
            Dialogue_Button.sprite = Button;
            collide.enabled = true;
            _text.text = "Great! Make sure to get close to the pen when you whistle to make sure all sheep leave and do it a couple times until you got all Sheep!";
            if (clicks == 1)
            {

                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if(gateOpen == true)
        {
            Dialogue_Box.sprite = Sheep_Dialogue;
            Dialogue_Button.sprite = Button;
            collide.enabled = true;
            _text.text = "If the sheep take too long to get out you can open up the profile Menu and click on GotToPlayer after clicking on the whistleButton";
            if (clicks == 1)
            {

                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if(leaveForSheep == true)
        {
            Dialogue_Box.sprite = Sheep_Dialogue;
            Dialogue_Button.sprite = Button;
            collide.enabled = true;
            _text.text = "Click on the SheepGate to let the sheep out";
            if (clicks == 1)
            {

                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if (tasksLook == true)
        {
            Dialogue_Box.sprite = Sheep_Dialogue;
            Dialogue_Button.sprite = Button;
            collide.enabled = true;
            profileButtonHighlight.SetActive(false);
            _text.text = "Now we're ready to go herd! go outside.";
            if (clicks == 1)
            {

                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if (closedCal == true)
        {
            openedCal = false;
            Dialogue_Box.sprite = Sheep_Dialogue;
            Dialogue_Button.sprite = Button;
            collide.enabled = true;
            profileButtonHighlight.SetActive(true);
            _text.text = "Now you can access your mission by clicking on your profile button then the tasks button" +
                    " if you ever forget";
            if (clicks == 1)
            {

                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
          
        }
        
        if(openedCal == true)
        {
            _text.text = "Wow it looks like we are going to Nowa Wies today, click on the day to set a reminder for yourself";
            if(clicks == 1)
            {
                _text.text = "Click on the Calendar date to add the task to your task list and X out of the calendar";
            }
           
            if (clicks == 2)
            {
                
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if(GameObject.FindGameObjectsWithTag("itemsInChest").Length == 1)
        {
            mealInInv = false;
            mealEaten = false;
            _text.text = "Ok, now X out and check your calender on the right for your assigned grazing ground today!";
            Dialogue_Box.sprite = Sheep_Dialogue;
            Dialogue_Button.sprite = Button;
            collide.enabled = true;
            if (clicks == 3)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if (mealEaten == true)
        {
            _text.text = "I dont think you need your flashlight anymore. Lets place it into the chest.";
            Dialogue_Box.sprite = Sheep_Dialogue;
            Dialogue_Button.sprite = Button;
            collide.enabled = true;
            
            if (clicks == 2)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if (mealInInv == true)
        {
            _text.text = "Now, you can eat the meal my moving the flashlight up to the meals spot and letting go to make them switch";
            Dialogue_Box.sprite = Sheep_Dialogue;
            Dialogue_Button.sprite = Button;
            collide.enabled = true;
           
               if (clicks == 1)
                {
                    Dialogue_Button.sprite = null;
                    Dialogue_Box.sprite = null;
                    collide.enabled = false;
                    _text.text = "";
                }
            if (main_PlaceHolder.name == "meal")
            {
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    mealEaten = true;
                    mealInInv = false;
                }
            }
           
            
        }
        if(doneCooking == true)
        {
            _text.text = "Great! Click on the meal on the oven to add it to your inventory.";
            Dialogue_Box.sprite = Sheep_Dialogue;
            Dialogue_Button.sprite = Button;
            collide.enabled = true;
            if (clicks == 1)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
       
        if (cookInHouse == true)

        {
            Timer += Time.deltaTime;
            if (Timer < 2)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }

            if (Timer > 2)


            {
                _text.text = "Click on the oven to open up the menu. then click MAKE, under barszcz czerwony.";
                Dialogue_Box.sprite = Sheep_Dialogue;
                Dialogue_Button.sprite = Button;
                collide.enabled = true;

            }
            if(clicks == 1)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if(leaveShopAgain == true)
        {
            Timer += Time.deltaTime;
            if (Timer < 2)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }

            if (Timer > 2)


            {
                _text.text = "Now lets return home to cook.";
                Dialogue_Box.sprite = Sheep_Dialogue;
                Dialogue_Button.sprite = Button;
                collide.enabled = true;

            }
            if (clicks == 1)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if(enterShopAgain == true)
        {
            Timer += Time.deltaTime;
            if (Timer < 2)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }

            if (Timer > 2)

                
            {
                _text.text = "Some Barszcz would sound nice today! Buy Onions, Beets and Carrots to make it.";
                Dialogue_Box.sprite = Sheep_Dialogue;
                Dialogue_Button.sprite = Button;
                collide.enabled = true;

            }
           else if (clicks == 1)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if(leaveShop == true)
        {
            Timer += Time.deltaTime;
           
            if (Timer > 2)
            {
                Dialogue_Box.sprite = Sheep_Dialogue;
                Dialogue_Button.sprite = Button;
                collide.enabled = true;
                _text.text = "Its time to sleep now. enter your house by clicking the the same way as you entered the shop!";
            }
            if (clicks == 1)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if(wakeUp == true)
        {
            Dialogue_Box.sprite = Sheep_Dialogue;
            Dialogue_Button.sprite = Button;
            collide.enabled = true;

            _text.text = "Wake up! It is time to go tend the sheep!";
            if (clicks == 1)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if (leaveHouse == true)
        {
            Timer += Time.deltaTime;
            if (Timer < 6)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
                energybarHighlight.SetActive(true);
            }

            if (Timer > 6)

               
            {
                _text.text = "Uh oh! it looks like you lost some energy during the night. Lets go to the store to buy some food.!";
                Dialogue_Box.sprite = Sheep_Dialogue;
                Dialogue_Button.sprite = Button;
                collide.enabled = true;
                Destroy(energybarHighlight);

            }
            if (clicks == 1)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
      if(inHouse == true)
        {
            
            Timer += Time.deltaTime;
            if(Timer < 3)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
            if (Timer > 3)
            {
                Dialogue_Box.sprite = Sheep_Dialogue;
                Dialogue_Button.sprite = Button;
                collide.enabled = true;
                _text.text = "From your Left you have your oven, to cook food, your chest to hold items you cant hold in your inventroy, your calender" +
                    "which tells you where the shopeeper wants you to take your sheep each day, and your bed in which you will sleep.";
                
            }
            if(clicks == 1)
            {
                _text.text = "Its pretty late now. Click on the bed to go to sleep. You have a big day tomorrow!";
            }
            if(clicks == 2)
            {
                Dialogue_Box.sprite = null;
                Dialogue_Button.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
        }
        if (inShop == true)
        {
            
            Timer += Time.deltaTime;
            if (Timer < 3)
            {
                Dialogue_Button.sprite = null;
                Dialogue_Box.sprite = null;
                collide.enabled = false;
                _text.text = "";
            }
            if (Timer > 3)
            {
                Dialogue_Box.sprite = ShopKeeper_Dialogue;
                Dialogue_Button.sprite = Button;
                collide.enabled = true;
                _text.text = "Ho ho ho! Welcome young traveler! you must be that shepherd I ordered!";
            }   
                if (clicks == 1)
                {
                    
                    _text.text = "Except there are four of you I need. And I wanted you four months ago!";
                    Timer = 3;
                }
                if (clicks == 2)
                {
                    
                    _text.text = "Oh well. you will be fine. But it is November now, and you will have more sheep too deal with in colder weather!";
                }
                if (clicks == 3)
                {
                   
                    _text.text = "Here. Sign this contract here. I give you free housing and some money and you give me work.";
                }
                if(clicks == 4)
                {
                    Contract.SetActive(true);
                    Dialogue_Box.sprite = null;
                    Dialogue_Button.sprite = null;
                collide.enabled = false;
                    _text.text = "";
                    whitesquare.SetActive(true);
                pencil.SetActive(true);
                }
            if(afterContract == true)
            {
                if (afterYesButtonClicked == true)
                {
                    _text.text = "Now the flashlight has been placed your primary inventory making it active. non active items are stored in smaller slots." +
                        " Click on the slot to turn on your flashlight";
                    if(clicks == -2)
                    {
                        _text.text = "You can change which object is in the primary " +
                               "box by dragging the primary object to one of the smaller slots.";
                    }
                    if(clicks == -1)
                    {
                        _text.text = "Now for your job.";
                    }
                    if(clicks == 0)
                    {
                        _text.text = "I have already marked off all of the daily routes you need to take in the calender in my guest house, each day you will take sheep to the area" +
                            " I want and I will pay you back depending on how well they fared";
                    }
                    if(clicks == 1)
                    {
                        _text.text = "Soon should be getting some new sheep down from the north so get ready to take them into your flock";
                    }
                    if(clicks == 2)
                    {
                        _text.text = "Now that is all, go get some good sleep. Good night!";
                    }
                    if(clicks == 3)
                    {
                        collide.enabled = false;
                        Dialogue_Box.sprite = null;
                        Dialogue_Button.sprite = null;
                        
                        _text.text = "";
                        inShop = false;
                    }
                }
                else
                {
                    if (quickCheck)
                    {
                        _text.text = "for example If you want to buy nice looking flashlight to walk home in the dark, click on Flashlight item and after deciding " +
                       "if you want or not click yes";
                    }
                    else
                    {
                        _text.text = "Before you leave  Let me show you how shop works. Is a bit complicated.";
                    }
                }
                if(clicks == 1)
                {
                    flashlightHighlight.SetActive(true);
                    quickCheck = true;
                    _text.text = "for example If you want to buy nice looking flashlight to walk home in the dark, click on Flashlight item and after deciding " +
                        "if you want or not click yes";
                   
                   
                }
                
                if (afterFlashlightClick == true)
                {
                    Destroy(flashlightHighlight);
                    yesButtonHighlight.SetActive(true);
                    if(afterYesButtonClicked == true)
                    {
                        Destroy(yesButtonHighlight);
                       
                        
                       
                    }
                    
                }
            }
        }   





    }

    public void OnMouseDown()
    {
        clicks++;
        print("onmousedownworks");
        if (clicks == 1 && inShop == false)
        {
            _text.text = "Start by using the WASD keys to move towards the store on your right. " +
                "You will use it for the duration of your time here to eat survive and to make your life easier";
            square.SendMessage("Message2");
            
        }
        


    }
    public void enteredTrailhead()
    {
        trailheadEnter = true;
    }
    public void entered_shop()
    {
      
        inShop = true;
        clicks = 0;
    }
    public void contract_Signed()
    {
        afterContract = true;
        clicks = 0;
    }
    public void Flashlight_Clicked()
    {
        afterFlashlightClick = true;
        
    }
    public void yesButton_Clicked()
    {
        afterYesButtonClicked = true;
        clicks = -3;  //only reason it is negative one is so i dont have to shift down every line click event when inserting new line
    }
    public void Left_Shop()
    {
        clicks = 0;
        Timer = 0;
        leaveShop = true;
    }
    public void In_House()
    {
        leaveShop = false;
        inHouse = true;
        Timer = 0;
        clicks = 0;
    }
    public void Player_Wake_Up()
    {
        clicks = 0;
        inHouse = false;
        wakeUp = true;
    }
    public void Leaving_House()
    {
        clicks = 0;
        Timer = 0;
        wakeUp = false;
        leaveHouse = true;
    }
            public void entered_shop_For_Food()
            {
        clicks = 0;
                Timer = 0;
        leaveHouse = false;
                enterShopAgain = true;
            }
    public void Left_Shop_To_Cook()
    {
        clicks = 0;
        Timer = 0;
        enterShopAgain = false;
        leaveShopAgain = true;
    }
    public void In_House_To_Cook()
    {
        clicks = 0;
        Timer = 0;
        leaveShopAgain = false;
        cookInHouse = true;
    }
    public void Done_Cooking()
    {
        clicks = 0;
        Timer = 0;
        cookInHouse = false;
        doneCooking = true;
    }
    public void Meal_In_Inv()
    {
        clicks = 0;
        Timer = 0;
        doneCooking = false;
        mealInInv = true;
    }
    public void Open_calendar()
    {
        clicks = 0;
        Timer = 0;
        mealInInv = false;
        openedCal = true;
    }
    public void Tasks_Looked_At()
    {
        clicks = 0;
        Timer = 0;
        closedCal = false;
        tasksLook = true;
    }
    public void Calendar_Closed()
    {
        clicks = 0;
        Timer = 0;
        openedCal = false;
        closedCal = true;
        
    }
    public void Leaving_House_For_Sheep()
    {
        clicks = 0;
        Timer = 0;
        tasksLook = false;
        leaveForSheep = true;
    }
    public void Gate_Open()
    {
        clicks = 0;
        Timer = 0;
        leaveForSheep = false;
        gateOpen = true;
       
    }
    public void whistleButton_Clicked()
    {
        clicks = 0;
        Timer = 0;
        gateOpen = false;
        whistledForSheep = true;
        
    }
    public void Sheep_Left_Pen()
    {
        clicks = 0;
        Timer = 0;
        whistledForSheep = false;
        sheepLeavePen = true;
    }
}
