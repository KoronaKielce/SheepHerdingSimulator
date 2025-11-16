using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animating : MonoBehaviour
{
    public float Timer;
    public Animator anim;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        anim.SetTrigger("transitionopen");
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (anim.GetBool("transitionopen") == true)
        {
            
        }
        
        if (Timer > 4)
        {
            anim.SetTrigger("transitionclose");
        }
        
    }
    public void switchposition()
    {
        transform.position = new Vector3(0.22f, -9.26f, -4);
    }
}