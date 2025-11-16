using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onPenClick : MonoBehaviour
{
    public Sprite openGate;
    public Sprite closeGate;
    public SpriteRenderer rend;
    public GameObject sheepLeavePen;
    public bool close = true;
    public float timesOpened = 0;
    public GameObject Dialogue;
    // Start is called before the first frame update
    void Start()
    {
        sheepLeavePen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        if(close == true)
        {
            timesOpened++;
            rend.sprite = openGate;
            sheepLeavePen.SetActive(true);
            close = false;
        }
       else if(close == false)
        {
            rend.sprite = closeGate;
            sheepLeavePen.SetActive(false);
            close = true;
        }
        if(timesOpened == 1)
        {
            Dialogue.SendMessage("Gate_Open");
            timesOpened = 2;
        }
    }
}
