using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

/*10/18/2024
 * I went from having a fully functioning intertwined animator that made it possible to get to one state from any other state
 * (which eventually became very very messy), to having an animator that ran through idle state every time I wanted to change
 * a state, to getting rid of half of my animation and instead overlaying over the player if that makes sense. MONTHS of works
 * wasted creating an overcompicated system jjust to realize that simplicity is ultimately better. I feel like eventually
 * Ill go back and revise all of my programs to be as simple as possible.
 */
public class checkTag : MonoBehaviour
{
    Animator anim;
   public GameObject playerArm;
    public float Timer = 0;
    public int oneTime = 0;
    public int oneTime2 = 0;
    public int oneTime3 = 0;
     public int oneTime0 = 0;
    public GameObject playerFlashLight;
    // Start is called before the first frame update
    void Start()
    {
        
       
       anim  = GameObject.Find("player").GetComponent<Animator>();
         //playerArm = GameObject.Find("playerArm");                                                   
      //  playerArm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        playerFlashLight = GameObject.Find("playerFlashlight");
        playerArm = GameObject.Find("playerArm");

        /* if (gameObject.tag == "clicked")
         {
             playerFlashLight.SetActive(false);
             oneTime0++;
             if (oneTime0 == 1) {
                 anim.SetTrigger("backToNormalPlayer");
                 //  anim.ResetTrigger("backToNormalPlayer");
                 anim.ResetTrigger("goToFlashlight");
                 anim.ResetTrigger("goToFlashlightMain");
                 // anim.SetTrigger("goToFlashlightMain");
                  anim.ResetTrigger("goToFlashlight");
                 //   playerArm.SetActive(true);
                 //playerArm.GetComponent<SpriteRenderer>().enabled = true;
                 //playerArm.transform.GetChild(0).gameObject.SetActive(true);
             }
         }
        else if(gameObject.tag != "clicked" && oneTime0 == 1)
         {
             anim.ResetTrigger("backToNormalPlayer");
             anim.ResetTrigger("back to Idle");
             oneTime0 = 0;
         }*/



        if (gameObject.tag == "mouseHeld")
        {

            playerFlashLight.GetComponent<SpriteRenderer>().enabled = false;
            if (playerArm.transform.parent.gameObject.GetComponent<SpriteRenderer>().enabled == true)
            {
                playerArm.GetComponent<SpriteRenderer>().enabled = true;
                playerArm.transform.Find("Light 2D").gameObject.GetComponent<Light2D>().enabled = true;
           }   
        else
        {
            playerArm.GetComponent<SpriteRenderer>().enabled = false;
            playerArm.transform.Find("Light 2D").gameObject.GetComponent<Light2D>().enabled = false;
            }
            anim.SetTrigger("goToFlashlightMain");
            anim.ResetTrigger("backToNormalPlayer");
            
                       // anim.ResetTrigger("back to Idle");


                       // anim.ResetTrigger("goToFlashlight");
                                          
                }
                 if (gameObject.tag == "itemsininventory(1st)" || gameObject.tag == "itemsininventory(2nd)" || gameObject.tag == "itemsininventory(3rd)" || gameObject.tag == "itemsininventory(4th)")
                {
            playerArm.GetComponent<SpriteRenderer>().enabled = false;
            playerFlashLight.GetComponent<SpriteRenderer>().enabled = true;          
            anim.SetTrigger("backToNormalPlayer");
            anim.ResetTrigger("goToFlashlightMain");
           
                   
        }
                    /*  if (Timer > 0.06f && oneTime == 1)
                     {
                         anim.ResetTrigger("goToFlashlightMain");
                         oneTime = 0;
                     }
                     if (gameObject.tag == "itemsininventory(1st)" || gameObject.tag == "itemsininventory(2nd)" || gameObject.tag == "itemsininventory(3rd)" || gameObject.tag == "itemsininventory(4th)")
                     {
                         oneTime2++;
                         if (oneTime2 == 1)
                         {
                             anim.SetTrigger("goToFlashlight");
                             // anim.ResetTrigger("goToFlashlight");
                            // anim.ResetTrigger("goToFlashlightMain");
                            // anim.ResetTrigger("backToNormalPlayer");
                            // anim.ResetTrigger("back to Idle");
                             playerArm.GetComponent<SpriteRenderer>().enabled = false;
                             playerArm.transform.GetChild(0).gameObject.SetActive(false);
                             if(Timer > 0.51f && oneTime2 == 1)
                             {
                                 anim.ResetTrigger("goToFlashlight");
                                 oneTime2 = 0;

                             }
                             Timer = 0;
                         }
                     }
                     else
                     {

                     }*/
                    if (gameObject.tag == "itemsInChest")
                {
                   // oneTime3++;
                 /*   if (oneTime3 == 1)
                    {
                        //player wouldnt go back to normal for a while just because below line was put below the resets
                        anim.SetTrigger("backToNormalPlayer");
                        //   anim.ResetTrigger("backToNormalPlayer");
                        anim.ResetTrigger("goToFlashlight");
                        anim.ResetTrigger("goToFlashlightMain");
                        playerArm.GetComponent<SpriteRenderer>().enabled = false;
                        playerArm.transform.GetChild(0).gameObject.SetActive(false);
                        Timer = 0;
                    }*/
                }
                 if (Timer > 0.06f && oneTime3 == 1)
                {
                    anim.ResetTrigger("backToNormalPlayer");
                    oneTime3 = 0;
                }
            
          
           

       
    }
}
