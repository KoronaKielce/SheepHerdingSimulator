using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changepos : MonoBehaviour
{
    public GameObject cam;
    public float timer;
    public bool time = false;
    public Camera cam2;
    // Start is called before the first frame update
    void Start()
    {
       // cam2 = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("e"))
        {
            
            time = true;
        }
    }
    public void intohouse()
    {
        if (time == true)
        {
            timer += Time.deltaTime;
            if (timer > 1f)
            {
                cam2.orthographicSize = 2f;
                transform.position = new Vector3(-0.072f, -11.7265f, 0);
                time = false;
                timer = 0;
            }
        }
    }
    public void outofhouse()
    {
        if (time == true)
        {
            timer += Time.deltaTime;
            if (timer > 1f)
            {
                cam2.orthographicSize = 3.95f;
                transform.position = new Vector3(-2.99999f, 0, -10);
                time = false;
                timer = 0;
            }
        }
    }
}
