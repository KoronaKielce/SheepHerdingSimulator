using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchingpos : MonoBehaviour
{
    public Transform house;
    public GameObject transition;
    public Camera cam1;
    public Camera cam2;
    public bool change = false;
    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        transition = GameObject.Find("transition");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void switchposition()
    {

        cam1.enabled = false;
        cam2.enabled = true;
       
       if(change == false)
            {

                transform.position = new Vector3(house.position.x, house.position.y - 2.452f, 0);
          
            change = true;
            }

    }
}
