using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink_opacity_contract_highlight : MonoBehaviour
{
    public SpriteRenderer rend;
    public float alpha = 1;
    public bool change = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(alpha >= 0 )
        {
            if (change == false)
            {
                alpha -= 0.015f;
            }
            
        }
        if(alpha <= 0)
        {
            change = true;
        }
        if (alpha >= 1)
        {
            change = false;
        }
        if (alpha <= 1)
        {
            if (change == true)
            {
                alpha += 0.015f;
            }
           
        }
        rend.color = new Color(1, 1, 1, alpha);
    }
}
