using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMain : MonoBehaviour
{
    GameObject same;
    public float once = 0;
    SpriteRenderer rend;
    public GameObject otherMain;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
      
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
            if (otherMain.name == "meal")
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = null;
            }
        }
        }
    public void spawnMainItem(GameObject main)
    {
        otherMain = main;
        print(main.name + "jjj");
        gameObject.GetComponent<SpriteRenderer>().sprite = main.GetComponent<SpriteRenderer>().sprite;
        gameObject.transform.localPosition = new Vector3(0.262f, -0.19f, 1);
        gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 1);
        if (main.name == "meal")
        {
            print("nnn");
            gameObject.transform.localScale = new Vector3(1f, 1f, 1);
            gameObject.transform.localPosition = new Vector3(0.26001f, -0.210029f, 1);
        }
        if (main.name == "Pork")
        {
            print("nnn");
            gameObject.transform.localScale = new Vector3(0.6f, 0.6f, 1);
        }
        if (main.name == "Flashlight")
        {
            print("nnn");
            gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = 6;

    }
    public void deleteMainItem()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = null;
    }
}
