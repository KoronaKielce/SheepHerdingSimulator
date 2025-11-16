using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whistleLeavePlayer : MonoBehaviour
{
    public SpriteRenderer rend;
    public GameObject sheepSpawn;
    public GameObject whistleFace;
    public bool whistling = false;
    public float Timer;
    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        rend.color = new Color(255, 255, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (whistling == true)
        {
            whistleFace.SetActive(true);
            sheepSpawn.BroadcastMessage("goToPlayer");
            Timer += Time.deltaTime;
            if (Timer > 1.5f) //3 is the time parameter for how long player cant whistle again and whistling animation can play
            {
                whistleFace.SetActive(false);
                whistling = false;
            }
        }
    }
    public void OnMouseOver()
    {
        rend.color = new Color(255, 255, 255, 255);
    }
    public void OnMouseExit()
    {
        rend.color = new Color(255, 255, 255, 0);
    }
    public void OnMouseDown()
    {
        if (whistling == false)
        {

            whistling = true;
        }
        

    }
}
