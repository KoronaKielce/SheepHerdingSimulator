using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickYes : MonoBehaviour
{
    public GameObject UI;
    GameObject sendItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BeginBlur(GameObject Item)
    {
        sendItem = Item;
        
    }
    public void OnMouseDown()
    {
        UI.BroadcastMessage("goToUI", sendItem);
        print(sendItem.name);
    }

}
