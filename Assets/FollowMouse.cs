using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    Vector3 mouse;
    public Camera cam;
    Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        mousePos = cam.ScreenToWorldPoint(mouse);
        gameObject.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
    }
}
