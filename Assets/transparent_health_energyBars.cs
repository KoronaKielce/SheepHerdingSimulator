using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparent_health_energyBars : MonoBehaviour
{
    public SpriteRenderer rend;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Camera.transform.position.y < -1)
        {
            rend.color = new Color(255, 255, 255, 0);
        }
        else
        {
            rend.color = new Color(255, 255, 255, 255);
        }
    }
}
