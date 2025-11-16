using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secndCamChangeSize : MonoBehaviour
{
    public Camera Main;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Camera>().orthographicSize = Main.orthographicSize;
    }
}
