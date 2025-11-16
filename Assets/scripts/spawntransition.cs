using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawntransition : MonoBehaviour
{
    public GameObject transition;
    bool detection = false;
    public GameObject parent;
    public GameObject player;
    public float zpos;
    public float Timer;
    bool Timeron = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Timer > 2.5f)
        {
            player.SendMessage("switchposition");

         
        }
        if (Timeron == true)
        {
            Timer += Time.deltaTime;
        }
        if (detection == true)
        {

            if (Input.GetKeyDown("e"))
            {
                Timeron = true;

                GameObject trans = Instantiate(transition, new Vector3(0, -10.32f, -5), Quaternion.identity);
                trans.gameObject.transform.localScale = new Vector3(12, 8, 0);
                Instantiate(transition, new Vector3(parent.transform.position.x, parent.transform.position.y, zpos), Quaternion.identity);
                Instantiate(trans);

            }
        }
    }
    


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("house"))
        {
            detection = true;

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        detection = false;
    }
}


