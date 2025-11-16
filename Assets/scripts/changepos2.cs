using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changepos2 : MonoBehaviour
{
    public GameObject cam;
    public float timer;
    public bool time = false;
    public Camera cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("e"))
        {

            time = true;
        }
    }
    public void intoShop()
    {
        if (time == true)
        {
            timer += Time.deltaTime;
            if (timer > 1f)
            {
                cam2.orthographicSize = 2.81f;
                transform.position = new Vector3(30, -11, 0);
                time = false;
                timer = 0;
            }
        }
    }
    public void outOfShop()
    {
        if (time == true)
        {
            timer += Time.deltaTime;
            if (timer > 1f)
            {
                cam2.orthographicSize = 3.95f;
                transform.position = new Vector3(4.1f, 0, 0);
                time = false;
                timer = 0;
            }
        }
    }
}
