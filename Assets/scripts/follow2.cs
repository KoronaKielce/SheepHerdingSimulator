using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow2 : MonoBehaviour
{

    public Transform TrackingTarget;




    // Update is called once per frame
    void Update()
    {
      
        
            transform.position = new Vector3(TrackingTarget.position.x,
               TrackingTarget.position.y, TrackingTarget.position.z);

        
    }

}





