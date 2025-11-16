using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{

    public Transform maincharacter;
    public float xpos;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        maincharacter = GameObject.Find("shepherd").transform;
        xpos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        var AScale = new Vector3(
transform.localScale.x * -1f,
transform.localScale.y,
transform.localScale.z);
        var DScale = new Vector3(
transform.localScale.x * -1f,
transform.localScale.y,
transform.localScale.z);
        if (Input.GetKey("d"))
        {
            if (xpos < maincharacter.transform.position.x)
            {
                if (Vector2.Distance(transform.position, maincharacter.position) > 1)
                {
                    if (transform.localScale.x == -1.5)
                    {
                        transform.localScale = DScale;
                        
                    }
                    transform.position = new Vector2(transform.position.x + 0.005f, Random.Range(transform.position.y - 0.005f, transform.position.y + 0.005f));
                    anim.SetTrigger("walking anim");
                }
            }
        }

        if (Input.GetKey("a"))
        {
            if (xpos > maincharacter.transform.position.x)
            {
                if (Vector2.Distance(transform.position, maincharacter.position) > 1)
                {
                    if (transform.localScale.x == 1.5)
                    {
                        transform.localScale = AScale;
                        
                    }
                    transform.position = new Vector2(transform.position.x - 0.005f, Random.Range(transform.position.y - 0.005f, transform.position.y + 0.005f));
                    xpos = transform.position.x;
                    anim.SetTrigger("walking anim");

                }
            }
        }
        if (Input.GetKeyUp("a"))
        {
            anim.ResetTrigger("walking anim");
            anim.SetTrigger("idle");
        }
        if (Input.GetKeyUp("d"))
        {
            anim.ResetTrigger("walking anim");
            anim.SetTrigger("idle");
        }


    }
}

