using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparent_energyLevels : MonoBehaviour
{
    public GameObject Camera;
    public GameObject energyBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.transform.position.y < -1)
        {
            energyBar.SetActive(false);
        }
        if(Camera.transform.position.y == 0) 
        {
            energyBar.SetActive(true);
        }
    }
}
