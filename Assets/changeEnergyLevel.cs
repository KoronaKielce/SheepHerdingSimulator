using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeEnergyLevel : MonoBehaviour
{
    public SpriteRenderer rend;
    public Sprite EnergyOne;
    public Sprite EnergyTwo;
    public Sprite EnergyThree;
    public Sprite EnergyFour;
    public Sprite EnergyFive;
    public float energyBound;
    public float preEnergyBound;
    public bool blinkChange = true;
    public Color def = new Color(224, 202, 202, 255);
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void walkingAmountUpdate(float playerEnergy)
    {
      
        if (energyBound > playerEnergy && playerEnergy > preEnergyBound)
        {

            
                if (blinkChange == true)
                {
                    StartCoroutine(blink());
                    
                }
                else
                {
                    StartCoroutine(blink2());
                    
                }
            }
        else
        {
            if (playerEnergy < energyBound)
            {
                 rend.color = def;
            }
        }
       
        if (playerEnergy > energyBound)
        {
           rend.color = new Color(255, 255, 255, 0);
        }

    }
    IEnumerator blink()
    {

        yield return new WaitForSeconds(0.25f);
        rend.color = new Color(224, 202, 202, 0);
        blinkChange = false;
        

    }
    IEnumerator blink2()
    {
        yield return new WaitForSeconds(0.25f);
        rend.color = def;
        blinkChange = true;
        
    }
}
