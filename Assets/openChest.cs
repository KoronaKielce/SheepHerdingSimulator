using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openChest : MonoBehaviour
{
    public GameObject chestInv;
    public GameObject whiteSquare;
    public GameObject xButton;
    public int accessedTimes = 0;
    public GameObject Dialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        accessedTimes += 1;
        if(accessedTimes == 1)
        {
            Dialogue.SendMessage("Open_calendar");
        }
        xButton.SetActive(true);
        chestInv.SetActive(true);
        whiteSquare.SetActive(true);
    }
}
