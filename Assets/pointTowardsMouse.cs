using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointTowardsMouse : MonoBehaviour
{
    public GameObject parent;
    float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - transform.position;
        
        //if(parent.transform.rotation.)
       
        if(parent.transform.localScale.x == -1)
        {
            angle = Vector2.SignedAngle(Vector2.right, -direction);
            if (angle > -60 && angle < 60)
            {
                transform.eulerAngles = new Vector3(0, 0, angle);
            }
        }
        else
        {
            angle = Vector2.SignedAngle(Vector2.right, direction);
            if (angle > -60 && angle < 60)
            {
                transform.eulerAngles = new Vector3(0, 0, angle);
            }
        }
    }
}
