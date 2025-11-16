using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maincharctermovement : MonoBehaviour
{
    public Animator anim;
    public Transform Playerpos;
    public float speed;
    public bool change = false;
    public bool change2 = false;
    public GameObject player;
    public float Timer;
    public bool timerStart = false;
    public int objChoose;
    public sortInventory toInv;
    public spawnMain playerHand;
    public float playerEnergy;
    public changeEnergyLevel walkingUpdate;
    public GameObject energyBar;
    public float energy;
    public bool wearingFlashLight = false;
    public SpriteRenderer playerRend;
    public Sprite playerWithFlashlight;
    public Sprite playerNormal;
    public GameObject playerArm;

    public GameObject inMain;
    public GameObject inSecondary;
    public int animTrans = 0;
    public float Timer2 = 0;
    public bool timerStart2 = false;
    public bool goBackToFlashlight = false;
    public int otherItem;
    public int nextAnim = 0;
    public float neg_X = float.NaN;      //NaN is undefined, set values to be values i wouldnt use otherwise by default
    public float pos_X = float.NaN;
    public float neg_Y = float.NaN;
    public float pos_Y = float.NaN;
    private static GameObject instance;
    public void useObject(int charhoose)
    {
        print("gn");
        objChoose = charhoose;

    }
    // Start is called before the first frame update
    void Start()
    {

        anim = gameObject.GetComponent<Animator>();
       // anim.ResetTrigger("r");


       // anim.SetTrigger("back to Idle");
        //playerArm.SetActive(false);
    }
    void Awake()
    {
        // anim.ResetTrigger("r");
        DontDestroyOnLoad(gameObject);

        if (instance == null) { 
            instance = gameObject;
        }
        else {
            Destroy(gameObject);

        }
    // anim.SetTrigger("back to Idle");
   

        }
        // Update is called once per frame
        public void intohouse()
    {
        change = false;
        change2 = true;

    }
    public void outofhouse()
    {
        change = false;
        change2 = false;
    }
    public void intoShop()
    {

        change = true;
        change2 = false;


    }
    public void outOfShop()
    {
        change = false;
        change = false;
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Trail Scene")
        {
            neg_Y = -4f;
            pos_Y = -2.82f;
        }
        else if (SceneManager.GetActiveScene().name == "playscene")
        {
            neg_Y = -2.95f;
            pos_Y = -1.8f;

        }
        /*
                if (GameObject.FindGameObjectsWithTag("mouseHeld").Length == 0)
                {
                    // playerArm.SetActive(false);
                    playerArm.GetComponent<SpriteRenderer>().enabled = false;
                }
                else
                {
                    inMain = GameObject.FindGameObjectWithTag("mouseHeld");
                    if (inMain.name == "Flashlight")
                    {
                        //

                    }
                    else
                    {
                        //  playerArm.SetActive(false);

                    }
                }*/
        /*  if(GameObject.FindGameObjectsWithTag("itemsininventory(1st)").Length == 0)
          {


          }
          else
          {
              inSecondary = GameObject.FindGameObjectWithTag("mouseHeld");
              if (inMain.name == "Flashlight")
              {
                  playerArm.SetActive(true);
              }
              else
              {
                  playerArm.SetActive(false);
              }
          }*/

        // if(wearingFlashLight == true)
        //   {
        //      anim.SetTrigger("goToFlashlight");
        // }

        //  walkingUpdate.walkingAmountUpdate(playerEnergy);
        if (SceneManager.GetActiveScene().name == "playscene")
        {
            energyBar.BroadcastMessage("walkingAmountUpdate", playerEnergy);
        }
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            playerEnergy++;
        }


        var AScale = new Vector3(
transform.localScale.x * -1f,
transform.localScale.y,
transform.localScale.z);
        var DScale = new Vector3(
transform.localScale.x * -1f,
transform.localScale.y,
transform.localScale.z);
        
        if (timerStart == true)
        {
            Timer += Time.deltaTime;
        }
        if (timerStart2 == true)
        {
            Timer2 += Time.deltaTime;
        }

        if (objChoose == 1)
        {

            if (Timer > 0.7f && Timer2 == 0)
            {
              /*  otherItem = findOtherInv();
                anim.ResetTrigger("eat");
                anim.SetTrigger("back to Idle");
                
                
                    
                    if (otherItem == 1)
                    {
                        
                    }
                              
                else
                {
                    timerStart = false;
                    objChoose = 0;

                    Timer = 0;

                }*/


          }
            /*if (Timer > 1.5f && nextAnim > 0)
            {
                anim.ResetTrigger("back to Idle");
                anim.SetTrigger("goToFlashlight");
                timerStart = false;
                objChoose = 0;

                Timer = 0;

            }
            if (Timer2 >= 0.575 && Timer2 < 0.585)
            {
                anim.ResetTrigger("back to Idle");
                anim.SetTrigger("backToNormalPlayer");
            }
            if (Timer2 >= 1)
            {

                anim.ResetTrigger("backToNormalPlayer");
                anim.ResetTrigger("back to Idle");
                anim.SetTrigger("eat");
                timerStart = true;
               
                print("drr");
                Destroy(GameObject.Find("meal"));
                toInv.ItemDeleted("meal");
                timerStart2 = false;
                playerHand.deleteMainItem();
                nextAnim = 1;
                Timer2 = 0;
            }*/
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                
               
              //  timerStart2 = true;
                anim.SetTrigger("eat");
                Destroy(GameObject.Find("meal"));
                toInv.ItemDeleted("meal");
                playerHand.deleteMainItem();
                nextAnim = 1;
                if (playerEnergy > energy)
                {
                    playerEnergy -= energy;
                    energy = 0; //this line might be wrong
                }
                else
                {
                    playerEnergy = playerEnergy - playerEnergy;
                }


            }

        }
        

        if (change == false && change2 == false)
        {

            if (Input.GetKey("d"))
            {

                if (float.IsNaN(pos_X))
                {


                    anim.SetTrigger("r");

                    transform.Translate(speed, 0, 0);
                }
                else
                {
                    if (player.transform.position.x < pos_X) //12.128
                    {
                        anim.SetTrigger("r");

                        transform.Translate(speed, 0, 0);

                    }
                }
            }
            if (Input.GetKeyDown("d"))
            {


                if (transform.localScale.x == -1)
                {
                    transform.localScale = DScale;

                }
            }
            if (Input.GetKeyUp("d"))
            {


                anim.ResetTrigger("r");


                anim.SetTrigger("back to Idle");

            }
            if (Input.GetKeyUp("a"))
            {


                anim.ResetTrigger("r");
                anim.SetTrigger("back to Idle");
            }
            if (Input.GetKeyDown("a"))
            {

                if (transform.localScale.x == 1)
                {
                    transform.localScale = AScale;

                }
            }
            if (Input.GetKey("a"))
            {

                if (float.IsNaN(neg_X))
                {
                    anim.SetTrigger("r");

                    transform.Translate(-speed, 0, 0);
                }
                else
                {

                    if (player.transform.position.x > neg_X)
                    {
                        anim.SetTrigger("r");

                        transform.Translate(-speed, 0, 0);
                    }
                }

            }
            if (Input.GetKey("w"))
            {


                if (float.IsNaN(pos_Y))
                {
                    anim.SetTrigger("r");

                    transform.Translate(0, speed, 0);
                }
                else
                {
                    if (player.transform.position.y < pos_Y) //-1.8
                    {
                        anim.SetTrigger("r");

                        transform.Translate(0, speed, 0);
                    }

                }

            }


            if (Input.GetKeyUp("w"))
            {

                anim.ResetTrigger("r");
                anim.SetTrigger("back to Idle");
            }
            if (Input.GetKey("s"))
            {
                if (float.IsNaN(neg_Y))
                {
                    anim.SetTrigger("r");

                    transform.Translate(0, -speed, 0);
                }
                else
                {

                    if (player.transform.position.y > neg_Y)  //-2.95
                    {
                        anim.SetTrigger("r");

                        transform.Translate(0, -speed, 0);
                    }
                }


            }


            if (Input.GetKeyUp("s"))
            {

                anim.ResetTrigger("r");
                anim.SetTrigger("back to Idle");
            }
        


    } 












        if (change)
        {
            if (Input.GetKey("d"))
            {

                anim.SetTrigger("r");
                if (Playerpos.position.x < 33.959f)
                {

                    transform.Translate(speed, 0, 0);
                }
            }
            if (Input.GetKeyDown("d"))
            {


                if (transform.localScale.x == -1)
                {
                    transform.localScale = DScale;

                }
            }
            if (Input.GetKeyUp("d"))
            {

                anim.ResetTrigger("r");
                anim.SetTrigger("back to Idle");

            }
            if (Input.GetKeyUp("a"))
            {

                anim.ResetTrigger("r");
                anim.SetTrigger("back to Idle");
            }
            if (Input.GetKeyDown("a"))
            {

                if (transform.localScale.x == 1)
                {
                    transform.localScale = AScale;

                }
            }
            if (Input.GetKey("a"))
            {
                if (Playerpos.position.x > 26f)
                {
                    anim.SetTrigger("r");
                    transform.Translate(-speed, 0, 0);
                }
            }
            if (Input.GetKey("w"))
            {


                if (Playerpos.position.y < -12.71f)
                {
                    transform.Translate(0, speed, 0);
                    anim.SetTrigger("r");
                }

            }


            if (Input.GetKeyUp("w"))
            {

                anim.ResetTrigger("r");
                anim.SetTrigger("back to Idle");
            }
            if (Input.GetKey("s"))
            {

                if (Playerpos.position.y > -13f)
                {
                    anim.SetTrigger("r");
                    transform.Translate(0, -speed, 0);
                }


            }
            if (Input.GetKeyUp("s"))
            {

                anim.ResetTrigger("r");
                anim.SetTrigger("back to Idle");
            }
        }
        if (change2)
        {


            if (Input.GetKey("d"))
            {

                anim.SetTrigger("r");
                if (Playerpos.position.x < 2.30399f)
                {

                    transform.Translate(speed, 0, 0);
                }
            }
            if (Input.GetKeyDown("d"))
            {


                if (transform.localScale.x == -1)
                {
                    transform.localScale = DScale;

                }
            }
            if (Input.GetKeyUp("d"))
            {

                anim.ResetTrigger("r");
                anim.SetTrigger("back to Idle");

            }
            if (Input.GetKeyUp("a"))
            {

                anim.ResetTrigger("r");
                anim.SetTrigger("back to Idle");
            }
            if (Input.GetKeyDown("a"))
            {

                if (transform.localScale.x == 1)
                {
                    transform.localScale = AScale;

                }
            }
            if (Input.GetKey("a"))
            {
                if (Playerpos.position.x > -2.48799f)
                {
                    anim.SetTrigger("r");
                    transform.Translate(-speed, 0, 0);
                }
            }
        }

    }

    public void getFoodEnergy(float energyAdded)
    {
        energy = energyAdded;
    }
    public void playerWithFlashLight()
    {
        print("trrr");
        wearingFlashLight = true;
    }
    public void playerWithFlashLightInMain()
    {
        print("trrr");
        wearingFlashLight = true;
    }
    int findOtherInv()
    {
        int Number = 0;
        GameObject UI = GameObject.Find("inventory(main)");
        for(int i = 0; i<UI.transform.childCount; i++)
        {
            print(UI.transform.GetChild(i).GetChild(0).name+"lllk");
            if(UI.transform.GetChild(i).GetChild(0).name == "Flashlight")
            {
                Number = 1;
                break;
            }
        
            
        }
        return Number;
    }
   
}
    


         