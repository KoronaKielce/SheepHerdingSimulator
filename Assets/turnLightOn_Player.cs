using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class turnLightOn_Player : MonoBehaviour
{
    public GameObject light;
    public GameObject longLight;
    public Animator anim;
    public GameObject playerArm;
    public float Timer = 0;
    public GameObject smallLightOn;
    public GameObject flashlightNeck;
    // Start is called before the first frame update
    void Start()
    {
        smallLightOn = GameObject.Find("flashlightOn");
        smallLightOn.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Flashlight = GameObject.Find("Flashlight");
        if (Flashlight.tag == "itemsininventory(1st)" || Flashlight.tag == "itemsininventory(2nd)" || Flashlight.tag == "itemsininventory(3rd)" || Flashlight.tag == "itemsininventory(4th)")
        {
            longLight.SetActive(false);
        }
        if (Flashlight.tag == "mouseHeld")
        {
            smallLightOn.GetComponent<SpriteRenderer>().enabled = false;
            light.SetActive(false);
        }
        if (Flashlight.tag == "clicked")
        {
            
          //  light.SetActive(false);
          //  longLight.SetActive(false);
        }
        if(Flashlight.tag == "itemsInChest")
        {
            light.SetActive(false);
            longLight.SetActive(false);
           // smallLightOn.GetComponent<SpriteRenderer>().enabled = false;
            flashlightNeck.GetComponent<SpriteRenderer>().enabled = false;
        }
        
    }
    public void changeLight(GameObject diffLight, bool Switch)
    {
        
        print(light.tag + "herre");
        if (diffLight.tag == "itemsininventory(1st)" || diffLight.tag == "itemsininventory(2nd)" || diffLight.tag == "itemsininventory(3rd)" || diffLight.tag == "itemsininventory(4th)")
        {
           
            longLight.SetActive(false);
            if (Switch == true)
            {
                smallLightOn.GetComponent<SpriteRenderer>().enabled = true;
                light.SetActive(true);
               
             
            }
            else
            {
                smallLightOn.GetComponent<SpriteRenderer>().enabled = false;
                light.SetActive(false);
               
                
             
            }
        }
       
        if (diffLight.tag == "mouseHeld")
        {
            // print(diffLight.transform.parent.gameObject.name + "kjh");
            
            light.SetActive(false);
            if (Switch == true)
            {
                longLight.SetActive(true);
                
            }
            else
            {
                longLight.SetActive(false);
                
            }
        }
    }
}
