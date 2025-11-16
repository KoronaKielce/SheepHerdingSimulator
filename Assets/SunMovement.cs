using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour
{
    public float y;
    public float x;
    public float xAdd;
    public float yAdd;
    public float area;
    // Start is called before the first frame update
    void Start()
    {
        area = -0.01f;
        
    }

    // Update is called once per frame
    void Update()
    {
        xAdd += 0.001f;
        yAdd = (xAdd*xAdd)*area+5;
        gameObject.transform.position = new Vector3(xAdd-10, yAdd, 0);
    }
}
