using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actualDeactivateChestCollider : MonoBehaviour
{
    public BoxCollider2D box;
    public float Timer = 0;
    public bool mouseHeld;

    // Start is called before the first frame update
    void Start()
    {
        box = this.gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0 && mouseHeld == false)
        {
            box.enabled = true;
        }

        if (transform.childCount == 1 && mouseHeld == false)
        {
            box.enabled = false;
        }
        if (mouseHeld == true)
        {
            box.enabled = true;
        }
        if (mouseHeld == false)
        {
            box.enabled = false;
        }

    }

    public void OnTriggerStay2D()
    {
        Timer += Time.deltaTime;
        if (Timer > 0.1f && Input.GetMouseButtonUp(0))
        {
            box.enabled = false;
            Timer = 0;
        }

    }
    public void OnTriggerExit2D()
    {
        Timer = 0;
    }
    public void MouseState(bool mouseType)
    {
        mouseHeld = mouseType;
    }
  
}
