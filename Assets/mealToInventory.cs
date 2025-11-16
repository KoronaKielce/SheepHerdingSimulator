using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mealToInventory : MonoBehaviour
{
   GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.Find("inventory(main)"); 
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void OnMouseDown()
    {
        if (gameObject.transform.parent.name == "mealSpawn")
        {
            UI.BroadcastMessage("goToUI", this.gameObject);
            Destroy(this.gameObject);
        }
    }
}
