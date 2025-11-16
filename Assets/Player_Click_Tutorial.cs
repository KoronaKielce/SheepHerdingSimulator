using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Click_Tutorial : MonoBehaviour
{
    public Text _text;
    public SpriteRenderer Dialogue_Box;
    public SpriteRenderer Dialogue_Button;
    public Sprite Sheep_Dialogue;
    public Sprite Button;
    public BoxCollider2D collide;
    public bool outOfShop = false;
    public float Timer = 0;
    public bool timerOn = false;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn == true)
        {
            Timer += Time.deltaTime;
            if (Timer > 2)
            {
                Dialogue_Box.sprite = Sheep_Dialogue;
                Dialogue_Button.sprite = Button;
                collide.enabled = true;
                _text.text = "Its time to sleep now. enter your house by clicking the the same way as you entered the shop!";
            }
        }
        if(outOfShop == true)
        {
            if (Input.GetKey("e"))
            {
                timerOn = true;
                
               
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == ("player"))
        {
            
                outOfShop = true;
                
            
        }
    }
}
