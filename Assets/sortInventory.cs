using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sortInventory : MonoBehaviour
{
    public bool mainInvFull = false;
    public bool secondInvFull = false;
    public bool thirdInvFull = false;
    public bool fourthInvFull = false;
    public bool fifthInvFull = false;
    public GameObject secondInv;
    public GameObject thirdInv;
    public GameObject fourthInv;
    public GameObject fifthInv;
    Vector3 mouse;
    bool mouseHeld = false;
    public Sprite prefabsprite;
    public Sprite prefabsprite2;
    Sprite oldSprite;
    public GameObject objectMainInv;
    public GameObject objectSecondInv;
    public GameObject objectThirdInv;
    public GameObject objectFourthInv;
    public GameObject objectFifthInv;
    //Added later on
    public GameObject main_placeHolder;
    public GameObject second_placeHolder;
    public GameObject third_placeHolder;
    public GameObject fourth_placeHolder;
    public GameObject fifth_placeHolder;
    public detectIngredients_Left Ingredient;
    public maincharctermovement charMove;
    public int charChoose;
    public float placeHolderFalse;
    public GameObject player;
    public maincharctermovement movement;
    public GameObject placeHolderForMain;
    // Start is called before the first frame update
    void Start()
    {
        mouse = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
      
        main_placeHolder = GameObject.FindGameObjectWithTag("mouseHeld");
        second_placeHolder = GameObject.FindGameObjectWithTag("itemsininventory(1st)");
        third_placeHolder = GameObject.FindGameObjectWithTag("itemsininventory(2nd)");
        fourth_placeHolder = GameObject.FindGameObjectWithTag("itemsininventory(3rd)");
        fifth_placeHolder = GameObject.FindGameObjectWithTag("itemsininventory(4th)");
        if (main_placeHolder != null)
        {
            mainInvFull = true;
        }
        else
        {
            mainInvFull = false;
        }
        if (second_placeHolder != null)
        {
            secondInvFull = true;
        }
        else
        {
            secondInvFull = false;
        }
        if (third_placeHolder != null)
        {
            thirdInvFull = true;
        }
        else
        {
            thirdInvFull = false;
        }
        if (fourth_placeHolder != null)
        {
            fourthInvFull = true;
        }
        else
        {
            fourthInvFull = false;
        }
        if (fifth_placeHolder != null)
        {
            fifthInvFull = true;
        }
        else
        {
            fifthInvFull = false;
        }
        print(main_placeHolder.name + "zf");
        if (mainInvFull == true)
        {
            if (main_placeHolder.name== "meal")
            {
                print("ng");
                charChoose = 1;
                charMove.useObject(charChoose);

            }
           
        }
    
    }
    public void goToUI(GameObject sortObject)
    {
        print(sortObject.name + "gbbb");
        if (sortObject.name == "Flashlight")
        {
            print("bbn");
            movement.playerWithFlashLight();
        }



        if (mainInvFull == false)
        {           
                    
                objectMainInv = Instantiate(sortObject, gameObject.transform.position, Quaternion.identity);
            objectMainInv.name = sortObject.name;
                objectMainInv.transform.localScale = new Vector3(0.7f, 0.7f, 0);
                objectMainInv.transform.parent = gameObject.transform;
                objectMainInv.tag = "mouseHeld";

               
           

        }
        else if(secondInvFull == false)
        {
            second_placeHolder = sortObject;
            objectSecondInv =  Instantiate(sortObject, secondInv.transform.position, Quaternion.identity);
            objectSecondInv.name = sortObject.name;
            objectSecondInv.transform.localScale = new Vector3(0.7f, 0.7f, 0);
            objectSecondInv.transform.parent = secondInv.transform;
            objectSecondInv.tag = "itemsininventory(1st)";
            
        }
        else if (thirdInvFull == false)
        {
            third_placeHolder = sortObject;
           
            objectThirdInv = Instantiate(sortObject, thirdInv.transform.position, Quaternion.identity);
            objectThirdInv.transform.localScale = new Vector3(0.7f, 0.7f, 0);
            objectThirdInv.name = sortObject.name;
            objectThirdInv.transform.parent = thirdInv.transform;
            objectThirdInv.tag = "itemsininventory(2nd)";
            
          
        
        }
        else if (fourthInvFull == false)
        {
            fourth_placeHolder = sortObject;
            objectFourthInv = Instantiate(sortObject, fourthInv.transform.position, Quaternion.identity);
            objectFourthInv.transform.localScale = new Vector3(0.7f, 0.7f, 0);
            objectFourthInv.name = sortObject.name;
            objectFourthInv.transform.parent = fourthInv.transform;
            objectFourthInv.tag = "itemsininventory(3rd)";
           
        }
        else if (fifthInvFull == false)
        {
            fifth_placeHolder = sortObject;
            objectFifthInv = Instantiate(sortObject, fifthInv.transform.position, Quaternion.identity);
            objectFifthInv.transform.localScale = new Vector3(0.7f, 0.7f, 0);
            objectFifthInv.name = sortObject.name;
            objectFifthInv.transform.parent = fifthInv.transform;
            objectFifthInv.tag = "itemsininventory(4th)";
            
        }
        
        Ingredient.IngredientsNames(main_placeHolder, second_placeHolder, third_placeHolder, fourth_placeHolder, fifth_placeHolder);
        if (mouseHeld == true)
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
            Debug.Log("works");
        }
        else if (mouseHeld == false)
        {
            
        }
       

    }
    //so basically when I tried to pass in "meal" to itemsdeleted, it couldn't equate it to mainplaceholder, cuz for some reason mainplaceholder
    //was null at this point, so I just manually fixed it, this part is concerning getting rid of meal from inventory, second part of code is in maincharctermovement
    //if ur interested

    public void ItemDeleted(string one)
    {
        print(one + "ggg");
        /*  if (one == "meal")
          {
              mainInvFull = false;
              print("kj");
          }*/
        if (one == objectMainInv.name)
        {
            mainInvFull = false;


        }
        if (one == objectSecondInv.name)
        {
            secondInvFull = false;

        }
        else if (one == objectThirdInv.name)
        {
            thirdInvFull = false;
        }


        else if (one == objectFourthInv.name)
        {
            fourthInvFull = false;

        }
        else if (one == objectFifthInv.name)
        {
            fifthInvFull = false;

        }
    }

    public void ItemsDeleted(string one, string two, string three, string four, string five)
    {
        print(one+"bff");
        print(objectMainInv.name + "fd");
        print(second_placeHolder.name + "lrr");
       
        if (one == main_placeHolder.name || two == main_placeHolder.name || three == main_placeHolder.name || four == main_placeHolder.name || five == main_placeHolder.name)
        {
            mainInvFull = false;
           
           
        }
       else if (one == second_placeHolder.name || two == second_placeHolder.name || three == second_placeHolder.name || four == second_placeHolder.name || five == second_placeHolder.name)
        {
            secondInvFull = false;
           
        }
      else if (one == third_placeHolder.name || two == third_placeHolder.name || three == third_placeHolder.name || four == third_placeHolder.name || five == third_placeHolder.name)
        {
            thirdInvFull = false;
        }
        
       
      else if(one == fourth_placeHolder.name || two == fourth_placeHolder.name || three == fourth_placeHolder.name || four == fourth_placeHolder.name || five == fourth_placeHolder.name)
        {
            fourthInvFull = false;
            
        }
      else if (one == fifth_placeHolder.name || two == fifth_placeHolder.name || three == fifth_placeHolder.name || four == fifth_placeHolder.name || five == fifth_placeHolder.name)
        {
            fifthInvFull = false;
           
        }

        placeHolderFalse = 0; 
        print("done");
    }
     public void OnMouseDown()
    {
        mouseHeld = true;
            
        
    }
    public void OnMouseExit()
    {
        mouseHeld = false;
    }
}
