using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class SheepWalk : MonoBehaviour
{
    public bool inSheepPen = true;
    public float Timer = 0;
    public float Timer2 = 0;
    public float Timer3 = 0;
    public float Timer4 = 0;
    public int Rand;
    public Animator anim;
    public bool leavePen;
    public SpriteRenderer rend;
    public float stopWalking;
    public bool whistleLeavePen = false;
    public bool inTrailNearShop = false;
    public bool enterPen = false;
    public float oldPos;
    public float Rand1;
    public float Rand2;
    public float Rand3;
    public float speed;
    public int randChooser;
    public float distance;
    public bool goToPlayerBool = false;
    public bool trailBehindPlayer = false;
    public float howFarBehindPLayer;
    public float randNegOrPos;
    public float walkMultiplier;
    private static GameObject instance;
    public int timesMade = 0;
    public float neg_X = float.NaN;      //NaN is undefined, set values to be values i wouldnt use otherwise by default
    public float pos_X = float.NaN;
    public float neg_Y = float.NaN;
    public float pos_Y = float.NaN;
    public float randomNumber;
    public int sceneChange = 0;
    public ToTrail Trail;
    public int stoppedWalking = 0;
    // Start is called before the first frame update
    void Start()
    {
       
        
        

        Debug.Log("Random Number: " + randomNumber);

    }
    void Awake()
    {
        Trail = GameObject.Find("SceneManager").GetComponent<ToTrail>();
        //moved from void start
        Timer = Random.Range(5, 20);
        Timer2 = Random.Range(5f, 10f);
        Timer3 = Random.Range(3, 9);
        
        Rand = Random.Range(0, 5);
        Rand1 = Random.Range(-0.004f, 0.004f);
        Rand2 = Random.Range(-0.004f, 0.004f);
        Rand3 = Random.Range(0.01f, 0.025f);
        oldPos = transform.position.x;


        if (instance == null)
        {
            instance = this.gameObject;
            DontDestroyOnLoad(gameObject);
            timesMade = 1;
        }
        else if(instance == this.gameObject && timesMade == 1)
        {
            Destroy(gameObject);

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Trail Scene" && sceneChange == 1)
        {
            neg_Y = -4.41f;
            pos_Y = -3.187f;
            randomNumber = Mathf.Sign(Random.Range(-1f, 1f)) * Mathf.Pow(Random.Range(0f, 1f), 1.4f);
            randomNumber = Mathf.Lerp(neg_Y, pos_Y, (randomNumber + 1f) / 2f) + GameObject.Find("player").transform.position.y - (neg_Y + pos_Y) / 2f;
            sceneChange = 0;
            walkMultiplier = Random.Range(0f, Trail.sheepFollowingAmount * 0.1f);
        }
        else if (SceneManager.GetActiveScene().name == "playscene" && sceneChange == 0)
        {
            neg_Y = -3.34f;
            pos_Y = -2.15f;
            walkMultiplier = Random.Range(0f, Trail.sheepFollowingAmount * 0.1f);

            randomNumber = Mathf.Sign(Random.Range(-1f, 1f)) * Mathf.Pow(Random.Range(0f, 1f), 1.1f);
            randomNumber = Mathf.Lerp(neg_Y, pos_Y, (randomNumber + 1f) / 2f) + GameObject.Find("player").transform.position.y - (neg_Y + pos_Y) / 2f;
            sceneChange = 1;
        }
        Vector3 playerPosLowered = new Vector3(GameObject.Find("player").transform.position.x, GameObject.Find("player").transform.position.y - 0.2f, GameObject.Find("player").transform.position.z);
        distance = Vector2.Distance(transform.position, GameObject.Find("player").transform.position);
        if (inSheepPen == true)
        {
            
            if (leavePen == false)
            {
                float Y = gameObject.transform.position.y;
                Y = -1.52f;

                Timer -= Time.deltaTime;
                if (Timer < 0)
                {
                    Rand = Random.Range(0, 5);
                    Timer = Random.Range(5, 7.5f);
                }
                if (Rand == 0)
                {
                    anim.ResetTrigger("walking anim");
                    anim.SetTrigger("idle");
                   
                }
                if (Rand == 1 && transform.position.x > -4.05f || Rand == 2 && transform.position.x > -4.05f)
                {

                    //Timer2 += Time.deltaTime;
                    transform.localScale = new Vector3(2.25f, transform.localScale.y, transform.localScale.z);
                    if (Timer - Random.Range(2.5f, 3) > 0)
                    {
                        transform.Translate(Random.Range(-0.006f, -0.0002f), 0, 0);
                       
                        anim.ResetTrigger("idle");
                        anim.SetTrigger("walking anim");
                    }
                    else
                    {
                        anim.ResetTrigger("walking anim");
                        anim.SetTrigger("idle");

                    }
                }
                if (Rand == 3 && transform.position.x < 3.2f || Rand == 4 && transform.position.x < 3.2f)
                {

                    //Timer3 += Time.deltaTime;
                    transform.localScale = new Vector3(-2.25f, transform.localScale.y, transform.localScale.z);
                    if (Timer - Random.Range(2.5f, 3) > 0)
                    {

                        transform.Translate(Random.Range(0.006f, 0.0002f), 0, 0);
                        anim.ResetTrigger("idle");
                        anim.SetTrigger("walking anim");
                        
                    }
                    else
                    {
                        anim.ResetTrigger("walking anim");
                        anim.SetTrigger("idle");
                    }
                }
            }
}
        if (leavePen == true)
        {
            if (transform.position.y > stopWalking)
            {
                transform.Translate(Random.Range(-0.000002f, 0.000002f), Random.Range(-0.006f, -0.0002f), 0);
                anim.ResetTrigger("idle");
                anim.SetTrigger("walking anim");
               
               
            }   
            else
            {
                anim.ResetTrigger("walking anim");
                anim.SetTrigger("idle");

                leavePen = false;
                inSheepPen = false;
                inTrailNearShop = true;
                Timer2 = Random.Range(5, 7.5f);
            }
            
            
        }
        if(whistleLeavePen == true)
        {
            if(transform.position.x > 0.35f)
            {
                transform.localScale = new Vector3(2.25f, transform.localScale.y, transform.localScale.z);
            }
            if (transform.position.x < 0.35f)
            {
                transform.localScale = new Vector3(-2.25f, transform.localScale.y, transform.localScale.z);
            }
            transform.position = Vector2.MoveTowards(transform.position, GameObject.Find("leaveSheepPen").transform.position, 0.006f);
            if(transform.position == GameObject.Find("leaveSheepPen").transform.position)
            { 
                whistleLeavePen = false;
            }
        }

        //Outside Pen

        if (inTrailNearShop == true && inSheepPen == false)
        {

            if (enterPen == false && leavePen == false)
            {




             
                //constrained sheep movement in ooutside of pen area to 3 sides, maybe just constrain to y levels for future
                // if (transform.position.y < -2.16f && transform.position.y > -3.354f && transform.position.x > -7.93f)
                //{

                // }

                if (transform.position.y > pos_Y || transform.position.y < neg_Y)
                {
                    Rand2 = -Rand2;


                }
                if (transform.position.x < pos_X)
                {
                    Rand1 = -Rand1;

                }
                if (Input.GetKeyDown("a") || Input.GetKeyDown("d"))
                {
                    Rand3 = Random.Range(0.6f / Trail.sheepFollowingAmount, 0.025f);
                    walkMultiplier = Random.Range(0f, Trail.sheepFollowingAmount * 0.1f);
                    Timer4 = Random.Range(0f, 2f);
                  
                    speed = 0;
                }
                if (Input.GetKeyUp("a") && stoppedWalking == 1 || Input.GetKeyUp("d") && stoppedWalking == 1)
                {
                   anim.ResetTrigger("walking anim");
                   anim.SetTrigger("idle");
                    stoppedWalking = 0;
                }
                    if (Input.GetKey("a") || Input.GetKey("d"))
                {
                   
                    Timer4 -= Time.deltaTime;
                    if (Timer4 <= 0)
                    {
                        if (Input.GetKey("d") && GameObject.Find("player").transform.position.x > transform.position.x + walkMultiplier)
                        {
                            Timer3 -= Time.deltaTime;
                            if(Rand3 > speed)
                            {
                                speed += 0.0001f;
                            }
                            if (Timer3 > 0)
                            {
                                stoppedWalking = 1;
                                anim.ResetTrigger("idle");
                                anim.SetTrigger("walking anim");
                                walkMultiplier += Random.Range(-0.00003f, 0.00003f);
                                transform.position = Vector3.Lerp(transform.position, new Vector3(GameObject.Find("player").transform.position.x-walkMultiplier, randomNumber, 0), speed);
                                
                               
                            }

                            if (Timer3 <= 0)
                            {

                                //randomNumber += Random.Range(-0.5f, 0.5f);
                                
                                Timer3 = Random.Range(3f, 9f);
                            }
                        }
                        else if (Input.GetKey("d") && GameObject.Find("player").transform.position.x < transform.position.x)
                        {
                            //could condense below block to be method that is called
                            if (Timer2 <= 0)
                            {
                                randChooser = Random.Range(0, 3);
                                randNegOrPos = Random.Range(0f, 1f);
                                if (randChooser == 0)
                                {
                                    Rand1 = 0;
                                    Rand2 = 0;
                                    Timer2 = Random.Range(5f, 10f);
                                }
                                if (randChooser == 1)
                                {
                                    Rand1 = Random.Range(0.0015f, 0.0005f);
                                    Rand2 = Random.Range(0.0015f, 0.0005f);
                                    if (randNegOrPos < 0.5f)
                                    {
                                        Rand1 = Rand1 * -1;
                                        Rand2 = Rand2 * -1;
                                    }
                                    Timer2 = Random.Range(5f, 10f);
                                }
                                if (randChooser >= 2)
                                {
                                    Rand1 = Random.Range(0.0035f, 0.0005f);
                                    Rand2 = Random.Range(0.0035f, 0.0005f);
                                    if (randNegOrPos < 0.5f)
                                    {
                                        Rand1 = Rand1 * -1;
                                        Rand2 = Rand2 * -1;
                                    }
                                    Timer2 = Random.Range(5f, 10f);
                                }

                            }
                            else if (Timer2 >= 0)
                            {
                                transform.Translate(Rand1, Rand2, 0);
                                Timer2 -= Time.deltaTime;
                            }
                        }
                        if (Input.GetKey("a") && GameObject.Find("player").transform.position.x < transform.position.x - walkMultiplier)
                        {
                            
                            Timer3 -= Time.deltaTime;
                            stoppedWalking = 1;

                            if (Timer3 > 0)
                            {
                                walkMultiplier += Random.Range(-0.00003f, 0.00003f);
                                transform.position = Vector3.Lerp(transform.position, new Vector3(GameObject.Find("player").transform.position.x + walkMultiplier, randomNumber, 0), Rand3);
                            }

                            if (Timer3 <= 0)
                            {
                                
                                   
                                
                                   
                                
                                walkMultiplier = Random.Range(0f, Trail.sheepFollowingAmount * 0.1f);
                                Timer3 = Random.Range(3f, 9f);
                            }
                        }
                        else if (Input.GetKey("a") && GameObject.Find("player").transform.position.x > transform.position.x)
                        {
                            if (Timer2 <= 0)
                            {
                                randChooser = Random.Range(0, 3);
                                randNegOrPos = Random.Range(0f, 1f);
                                if (randChooser == 0)
                                {
                                    Rand1 = 0;
                                    Rand2 = 0;
                                    Timer2 = Random.Range(5f, 10f);
                                }
                                if (randChooser == 1)
                                {
                                    Rand1 = Random.Range(0.0015f, 0.0005f);
                                    Rand2 = Random.Range(0.0015f, 0.0005f);
                                    if (randNegOrPos < 0.5f)
                                    {
                                        Rand1 = Rand1 * -1;
                                        Rand2 = Rand2 * -1;
                                    }
                                    Timer2 = Random.Range(5f, 10f);
                                }
                                if (randChooser >= 2)
                                {
                                    Rand1 = Random.Range(0.0035f, 0.0005f);
                                    Rand2 = Random.Range(0.0035f, 0.0005f);
                                    if (randNegOrPos < 0.5f)
                                    {
                                        Rand1 = Rand1 * -1;
                                        Rand2 = Rand2 * -1;
                                    }
                                    Timer2 = Random.Range(5f, 10f);
                                }

                            }
                        }
                    }
                }
                else
                {
                    Timer3 = 0;
                    if (goToPlayerBool == true && distance > 0.7f && -2.15f > transform.position.y && transform.position.y > -3.34f)
                    {
                        Timer2 = 0;
                        transform.position = Vector2.MoveTowards(transform.position, playerPosLowered, 0.006f);
                        if (distance > 0.7f && distance < 0.8f)
                        {

                            goToPlayerBool = false;
                        }
                    }

                    else if (distance < 0.7f)
                    {
                        Timer2 = 0;
                        transform.position = Vector2.MoveTowards(transform.position, playerPosLowered, -0.002f);
                    }
                    else
                    {


                        if (Timer2 <= 0)
                        {
                            randChooser = Random.Range(0, 3);
                            randNegOrPos = Random.Range(0f, 1f);
                            if (randChooser == 0)
                            {
                                Rand1 = 0;
                                Rand2 = 0;
                                Timer2 = Random.Range(5f, 10f);
                            }
                            if (randChooser == 1)
                            {
                                Rand1 = Random.Range(0.0015f, 0.0005f);
                                Rand2 = Random.Range(0.0015f, 0.0005f);
                                if (randNegOrPos < 0.5f)
                                {
                                    Rand1 = Rand1 * -1;
                                    Rand2 = Rand2 * -1;
                                }
                                Timer2 = Random.Range(5f, 10f);
                            }
                            if (randChooser >= 2)
                            {
                                Rand1 = Random.Range(0.0035f, 0.0005f);
                                Rand2 = Random.Range(0.0035f, 0.0005f);
                                if (randNegOrPos < 0.5f)
                                {
                                    Rand1 = Rand1 * -1;
                                    Rand2 = Rand2 * -1;
                                }
                                Timer2 = Random.Range(5f, 10f);
                            }

                        }
                        else if (Timer2 >= 0)
                        {
                            transform.Translate(Rand1, Rand2, 0);
                            Timer2 -= Time.deltaTime;
                        }

                    }
                }

               
                    /*else if(distance > 4.5f)
                    {
                        trailBehindPlayer = true;
                        if(trailBehindPlayer == true)
                        {
                            transform.position = Vector2.MoveTowards(transform.position, GameObject.Find("player").transform.position, 0.003f);
                        }
                        if(distance < 4)
                        {
                            trailBehindPlayer = false;
                        }
                    }*/
                    //////
                    ///


                    if (transform.position.x > oldPos)
                    {
                        transform.localScale = new Vector3(-2.25f, transform.localScale.y, transform.localScale.z);
                        oldPos = transform.position.x;
                    }
                    else if (transform.position.x < oldPos)
                    {
                        transform.localScale = new Vector3(2.25f, transform.localScale.y, transform.localScale.z);
                        oldPos = transform.position.x;
                    }
                    else
                    {

                    }
               /* if(Timer2 < 0)
                {
                    randChooser = Random.Range(0, 3);
                   
                    if (randChooser == 0)
                    {
                        Rand1 = 0;
                        Rand2 = 0;
                    }
                    if (randChooser == 1)
                    {
                        Rand1 = Random.Range(-0.0025f, 0.0025f);
                        Rand2 = Random.Range(-0.0025f, 0.0025f);
                    }
                    if (randChooser >= 2)
                    {
                        Rand1 = Random.Range(-0.0015f, 0.0015f);
                        Rand2 = Random.Range(-0.0015f, 0.0015f);
                    }
                    Timer2 = Random.Range(5, 7.5f);
                }*/


            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == ("leaveSheepPen"))
        {
            stopWalking = Random.Range(-2.5f, -3.4f);
            rend.sortingLayerName = "Default";
            leavePen = true;
            
        }
       
       
    }

    public void leavePlayer()
    {

    }
    public void goToPlayer()
    {
        if(inSheepPen == true && leavePen == false)
        {
            if (Random.Range(0, 1) < 0.7f)
            {
               
                 if (distance < 2.5f)
                {
                   
                    whistleLeavePen = true;
                }
            }
        }
        if(inSheepPen == false && inTrailNearShop == true && enterPen == false)
        {
            if (Random.Range(0, 1) < 0.5f)
            {

                if (distance < 2.5f)
                {

                    
                    goToPlayerBool = true;
                }
            }
            
        }
    }

    /* void moveLeftAuto(timeToMove)
    {
        Timer = 0;
        Timer += Time.deltaTime;
        transform.localScale = AScale;
        if (Timer < timeToMove) {
            transform.position = new Vector2(transform.position.x - 0.005f, -1.52f);
            anim.SetTrigger("walking anim");
        }
        else
        {
            anim.ResetTrigger("walking anim");
            anim.SetTrigger("idle");
        }
    }
     void moveRightAuto(timeToMove)
    {
        Timer = 0;
        Timer += Time.deltaTime;
        transform.localScale = DScale;
        if (Timer < timeToMove) {
            transform.position = new Vector2(transform.position.x + 0.005f, Random.Range, -1.52f);
            anim.SetTrigger("walking anim");
        }
        else
        {
            anim.ResetTrigger("walking anim");
            anim.SetTrigger("idle");
        }
    }*/

}
