using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeChest : MonoBehaviour
{
    public GameObject whiteSquare;
    public GameObject chestSpaces;
    public float timesClicked = 0;
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
        timesClicked++;
        if(timesClicked == 1)
        {
            Dialogue.SendMessage("Calendar_Closed");
        }
        whiteSquare.SetActive(false);
        chestSpaces.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
