using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public float speed;
    public Sprite oldsprite;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            anim.SetTrigger("walking left trigger");
            spriteRenderer.sprite = newSprite;
            
        }
        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("walk left"))
        {
            transform.Translate(-speed, 0, 0);
            spriteRenderer.sprite = newSprite;
        }
        if (Input.GetKeyUp("a"))
        {
            anim.ResetTrigger("walking left trigger");
            anim.SetTrigger("back to Idle");
            
        }




        if (Input.GetKey("d"))
        {
            anim.SetTrigger("walking right trigger");


            spriteRenderer.sprite = oldsprite;
        }
        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("walk right"))
        {
            transform.Translate(speed, 0, 0);
            spriteRenderer.sprite = oldsprite;
        }
        if (Input.GetKeyUp("d"))
        {
            anim.ResetTrigger("walking right trigger");
            anim.SetTrigger("back to Idle");
           

        }
    }
}
