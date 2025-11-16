using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnLightOn : MonoBehaviour
{
    public bool lightOn = false;
    turnLightOn_Player Light;
    public bool mainEntry = true;
    public bool seconEntry = true;
    // Start is called before the first frame update
    void Start()
    {
      Light =  GameObject.Find("player").GetComponent<turnLightOn_Player>();
    }

    // Update is called once per frame
    void Update()
    {
         /*if (gameObject.tag == "itemsInChest")
        {
            lightOn = false;
            Light.changeLight(this.gameObject, lightOn);
        }*/
    }
    public void OnMouseDown()
    {
        
        print(lightOn+"krr");
        if (gameObject.tag == "itemsininventory(1st)" || gameObject.tag == "itemsininventory(2nd)" || gameObject.tag == "itemsininventory(3rd)" || gameObject.tag == "itemsininventory(4th)")
        {
            if (seconEntry == true)
            {
                lightOn = true;
                Light.changeLight(this.gameObject, lightOn);
                mainEntry = true;
                seconEntry = false;

            }
            else
            {
                lightOn = !lightOn;
                Light.changeLight(this.gameObject, lightOn);
            }
        }
        else if (gameObject.tag == "mouseHeld")
        {
            if (mainEntry == true)
            {
                lightOn = true;
                Light.changeLight(this.gameObject, lightOn);
                seconEntry = true;
                mainEntry = false;
            }
            else
            {
                lightOn = !lightOn;
                Light.changeLight(this.gameObject, lightOn);
            }
        }
       
           
    }
}
