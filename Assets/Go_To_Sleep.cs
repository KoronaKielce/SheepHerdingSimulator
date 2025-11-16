using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go_To_Sleep : MonoBehaviour
{
    public Sprite sleeping;
    public Sprite Hover;
    public Sprite Normal;
    public SpriteRenderer rend;
    public TIme Time;
    public bool clicked = false;
    public GameObject player;
    public GameObject timeKeeper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(clicked == true)
        {
            rend.sprite = sleeping;
          
        }
    }
    
    public void OnMouseOver()
    {
        rend.sprite = Hover;
    }
    public void OnMouseExit()
    {
        rend.sprite = Normal;
    }
    public void OnMouseDown()
    {

        if (Time.dayTime < 2073)
        {
            player.GetComponent<SpriteRenderer>().enabled = false;
           // player.transform.Find("playerArm").GetComponent<SpriteRenderer>().enabled = false;
            timeKeeper.SendMessage("Speed_Up_Time");
            clicked = true;
           
            for (int j = 0; j < player.transform.childCount; j++)
            {
                if (player.transform.GetChild(j).gameObject.activeSelf)
                {
                    player.transform.GetChild(j).GetComponent<SpriteRenderer>().enabled = false;
                    print(player.transform.GetChild(j).gameObject.name + "klkj");
                }
                
                
            }
        }
    }
    public void Night_Over()
    {
        clicked = false;
        rend.sprite = Normal;
        player.GetComponent<SpriteRenderer>().enabled = true;
        for (int i = 0; i < player.transform.childCount;i++)
        {
            if (player.transform.GetChild(i).gameObject.activeSelf)
            {
                player.transform.GetChild(i).GetComponent<SpriteRenderer>().enabled = true;
            }
           
            
        }
    }
}
