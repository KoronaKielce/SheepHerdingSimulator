using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeBook : MonoBehaviour
{
    public GameObject mask;
    public GameObject player;
    public GameObject Panel;
    public GameObject oven;
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
       

            Panel.SendMessage("EndBlur", 5f);
            mask.SendMessage("EndBlur");
            player.SendMessage("EndBlur");
            oven.SendMessage("EndBlur");
        
    }
}
