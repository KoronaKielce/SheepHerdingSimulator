using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseOverTasks : MonoBehaviour
{
    public GameObject extension;
    public int close = 0;
    public float timesOpened = 0;
    public GameObject Dialogue;
    public SpriteRenderer rend;
    public Sprite newsprite;
    public Sprite oldsprite;
    public bool mouseIsOver = false;
    // Start is called before the first frame update
    void Start()
    {
        extension.SetActive(false);
    }

    // Update is called once per frame
   
    void Update()
    {
        if (mouseIsOver == true)
        {
            rend.sprite = newsprite;
        }
        else
        {
            rend.sprite = oldsprite;
        }

    }
    public void OnMouseOver()
    {

        mouseIsOver = true;
    }
    public void OnMouseExit()
    {
        mouseIsOver = false;
    }
    public void OnDisable()
    {
        mouseIsOver = false;
    }
    public void OnMouseDown()
    {
        if(close == 0)
        {
            timesOpened++;
            if(timesOpened == 1)
            {
                Dialogue.SendMessage("Tasks_Looked_At");
            }
            extension.SetActive(true);
            close += 1;
        }
       else if(close == 1)
        {
            extension.SetActive(false);
            close -= 1;
        }

    }
}
