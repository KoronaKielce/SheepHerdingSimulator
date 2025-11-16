 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectingredients_Right : MonoBehaviour
{
    public float recipeNumber;
    public float pageNumber;
    public GameObject mainInv;
    public GameObject inv1;
    public GameObject inv2;
    public GameObject inv3;
    public GameObject inv4;
    public SpriteRenderer rend;
    public bool mInv = false;
    public bool inv_1 = false;
    public bool inv_2 = false;
    public bool inv_3 = false;
    public bool inv_4 = false;
    public Sprite newsprite;
    public Sprite oldsprite;
    public GameObject mask;
    public GameObject player;
    public GameObject Panel;
    public GameObject oven;
    public int porkAmount = 0;
    public float timeSet;
    public ovenTimerCountDown count;
    public onmouseoverchangesprite_oven over;
    public bool timerDown = false;
    public ovenCook On;
    public bool mouseDown = false;
    public sortInventory inventory;
    public bool timerDown2;
    public spawnMain playerHand;
    public float energyAdded;
    public maincharctermovement playerFood;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        pageNumber = GameObject.Find("right arrow").GetComponent<Recipebookpagechange>().page;
        mainInv = GameObject.Find("inventory(main)").GetComponent<sortInventory>().objectMainInv;
        inv1 = GameObject.Find("inventory(main)").GetComponent<sortInventory>().objectSecondInv;
        inv2 = GameObject.Find("inventory(main)").GetComponent<sortInventory>().objectThirdInv;
        inv3 = GameObject.Find("inventory(main)").GetComponent<sortInventory>().objectFourthInv;
        inv4 = GameObject.Find("inventory(main)").GetComponent<sortInventory>().objectFifthInv;
        print(mainInv.name);
        if (pageNumber == 0)
        {
            rend.color = new Color(1, 1, 1, 0.5f);
            recipeNumber = 2;
            if (mainInv.name == "Onions" || inv1.name == "Onions" || inv2.name == "Onions" || inv3.name == "Onions" || inv4.name == "Onions")
            {
                if (mainInv.name == "Beets" || inv1.name == "Beets" || inv2.name == "Beets" || inv3.name == "Beets" || inv4.name == "Beets")
                {
                    if (mainInv.name == "Carrots" || inv1.name == "Carrots" || inv2.name == "Carrots" || inv3.name == "Carrots" || inv4.name == "Carrots")
                    {
                        rend.color = new Color(1, 1, 1, 1);
                        print("lllll");
                        timeSet = 4;
                        energyAdded = 5000;
                        timerDown = true;
                        playerFood.getFoodEnergy(energyAdded);
                        count.CountDownAmount(timeSet);
                        
                    }
                    else
                    {
                        energyAdded = 0;
                    }
                }
            }
        }
        else if (pageNumber == 1)
        {
            rend.color = new Color(1, 1, 1, 0.5f);
            recipeNumber = 4;


            if (mainInv.name == "Carrots" || inv1.name == "Carrots" || inv2.name == "Carrots" || inv3.name == "Carrots" || inv4.name == "Carrots")
            {
                if (mainInv.name == "Cabbage" || inv1.name == "Cabbage" || inv2.name == "Cabbage" || inv3.name == "Cabbage" || inv4.name == "Cabbage")
                {
                    if (mainInv.name == "Beef" || inv1.name == "Beef" || inv2.name == "Beef" || inv3.name == "Beef" || inv4.name == "Beef")
                    {
                        if (mainInv.name == "Pork" || inv1.name == "Pork" || inv2.name == "Pork" || inv3.name == "Pork" || inv4.name == "Pork")
                        {
                            if (mainInv.name == "Onions" || inv1.name == "Onions" || inv2.name == "Onions" || inv3.name == "Onions" || inv4.name == "Onions")
                            {
                                rend.color = new Color(1, 1, 1, 1);
                                print("lllll");
                                timeSet = 210;
                                energyAdded = 15000;
                                timerDown = true;
                                playerFood.getFoodEnergy(energyAdded);
                                count.CountDownAmount(timeSet);
                            }
                            else
                            {
                                energyAdded = 0;
                            }
                        }
                    }
                }
            }

        }
        else if (pageNumber == 2)
        {
            rend.color = new Color(1, 1, 1, 0.5f);
            recipeNumber = 6;
            if (mainInv.name == "Potatos" || inv1.name == "Potatos" || inv2.name == "Potatos" || inv3.name == "Potatos" || inv4.name == "Potatos")
            {
                if (mainInv.name == "Cabbage" || inv1.name == "Cabbage" || inv2.name == "Cabbage" || inv3.name == "Cabbage" || inv4.name == "Cabbage")
                {
                    if (mainInv.name == "Cucumbers" || inv1.name == "Cucumbers" || inv2.name == "Cucumbers" || inv3.name == "Cucumbers" || inv4.name == "Cucumbers")
                    {
                        if (mainInv.name == "Pork" || inv1.name == "Pork" || inv2.name == "Pork" || inv3.name == "Pork" || inv4.name == "Pork")
                        {
                            if (mainInv.name == "Carrots" || inv1.name == "Carrots" || inv2.name == "Carrots" || inv3.name == "Carrots" || inv4.name == "Carrots")
                            {
                                rend.color = new Color(1, 1, 1, 1);
                                print("lllll");
                                timeSet = 360;
                                energyAdded = 40000;
                                timerDown = true;
                                playerFood.getFoodEnergy(energyAdded);
                                count.CountDownAmount(timeSet);
                                print(timeSet + "herebr");
                                
                            }
                            else
                            {
                                energyAdded = 0;
                            }
                        }
                    }
                }
            }
        }
        if (pageNumber == 3)
        {
            rend.color = new Color(1, 1, 1, 0.5f);
            recipeNumber = 8;
            if (mainInv.name == "Pork")
            {
                mInv = true;
            }
            else if (inv1.name == "Pork" && mInv == false)
            {
                inv_1 = true;
            }
            else if (inv2.name == "Pork" && inv_1 == false)
            {
                inv_2 = true;
            }
            else if (inv3.name == "Pork" && inv_2 == false)
            {
                inv_3 = true;
            }
            else if (inv4.name == "Pork" && inv_3 == false)
            {
                inv_4 = true;
            }
            if (mInv == false && mainInv.name == "Pork" || inv_1 == false && inv1.name == "Pork" || inv_2 == false && inv2.name == "Pork" || inv_3 == false && inv3.name == "Pork" || inv_4 == false && inv4.name == "Pork")
            {
                if (mainInv.name == "Onions" || inv1.name == "Onions" || inv2.name == "Onions" || inv3.name == "Onions" || inv4.name == "Onions")
                {
                    if (mainInv.name == "Beef" || inv1.name == "Beef" || inv2.name == "Beef" || inv3.name == "Beef" || inv4.name == "Beef")
                    {
                        if (mainInv.name == "Cabbage" || inv1.name == "Cabbage" || inv2.name == "Cabbage" || inv3.name == "Cabbage" || inv4.name == "Cabbage")
                        {
                            rend.color = new Color(1, 1, 1, 1);
                            print("lllll");
                         timeSet = 290;
                            energyAdded = 25000;
                            timerDown = true;
                            playerFood.getFoodEnergy(energyAdded);
                            count.CountDownAmount(timeSet);
                        }
                    }
                }
            }
        }
       
       
        On.Cook(timerDown, timeSet);
       
        print(timeSet + "herebot");
        over.cookinOn(timerDown);
    }
    public void OnMouseOver()
    {
        if (rend.color == new Color(1, 1, 1, 1))
        {
            rend.sprite = newsprite;
        }
        
    }
    public void OnMouseExit()
    {
        rend.sprite = oldsprite;
    }

    public void OnMouseDown()
    {
        mouseDown = true;
        On.Appearance(mouseDown);
        
        if (rend.color == new Color(1, 1, 1, 1))
        {
            if(pageNumber == 0)
            {
                inventory.ItemsDeleted(null, null, "Onions", "Beets", "Carrots");
                Destroy(GameObject.Find("Onions"));
                Destroy(GameObject.Find("Beets"));
                Destroy(GameObject.Find("Carrots"));
            }
            if (pageNumber == 1)
            {
                inventory.ItemsDeleted("Pork", "Onions", "Cabbage", "Beef", "Carrots");
                Destroy(GameObject.Find("Carrots"));
                Destroy(GameObject.Find("Cabbage"));
                Destroy(GameObject.Find("Beef"));
                Destroy(GameObject.Find("Pork"));
                Destroy(GameObject.Find("Onions"));
            }
            if (pageNumber == 2)
            {
                inventory.ItemsDeleted("Pork", "Potatos", "Cabbage", "Cucumbers", "Carrots");
                Destroy(GameObject.Find("Potatos"));
                Destroy(GameObject.Find("Cabbage"));
                Destroy(GameObject.Find("Cucumbers"));
                Destroy(GameObject.Find("Pork"));
                Destroy(GameObject.Find("Carrots"));
              
            }
            if (pageNumber == 3)
            {
                //Doesnt work rn you probably have to move playerHand to somewhere else within the if statement
               //fixed same day
                inventory.ItemsDeleted("Pork", "Pork", "Cabbage", "Beef", "Onions");
                Panel.SendMessage("EndBlur", 5f);
                mask.SendMessage("EndBlur");
                player.SendMessage("EndBlur");
                oven.SendMessage("EndBlur");
                Destroy(GameObject.Find("Onions"));
                Destroy(GameObject.Find("Beef"));
                Destroy(GameObject.Find("Cabbage"));
                if (mainInv.name == "Pork")
                {
                    Destroy(GameObject.Find("inventory(main)").GetComponent<sortInventory>().objectMainInv);
                    porkAmount++;
                }
                if (inv1.name == "Pork" && porkAmount < 2)
                {
                    Destroy(GameObject.Find("inventory(main)").GetComponent<sortInventory>().objectSecondInv);
                    porkAmount++;
                }
                if (inv2.name == "Pork" && porkAmount < 2)
                {
                    Destroy(GameObject.Find("inventory(main)").GetComponent<sortInventory>().objectThirdInv);
                    porkAmount++;
                }
                if (inv3.name == "Pork" && porkAmount < 2)
                {
                    Destroy(GameObject.Find("inventory(main)").GetComponent<sortInventory>().objectFourthInv);
                    porkAmount++;
                }
                if (inv4.name == "Pork" && porkAmount < 2)
                {
                    Destroy(GameObject.Find("inventory(main)").GetComponent<sortInventory>().objectFifthInv);

                }
                playerHand.deleteMainItem();
            }
            Panel.SendMessage("EndBlur", 5f);
            mask.SendMessage("EndBlur");
            player.SendMessage("EndBlur");
            oven.SendMessage("EndBlur");
            oven.SendMessage("Cook");
            playerHand.deleteMainItem();
        }
    }
}
