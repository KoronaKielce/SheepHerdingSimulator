using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transition : MonoBehaviour
{
    public float Timer;
    public Animator anim;
    bool time = false;
    public GameObject trans;
    public float timesCalled = 0;
   
    public int n = 1;
    public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (time == true)
        {
            Timer += Time.deltaTime;
        }
        if (Timer > 2.5f   )
        {
            if (timesCalled > 300 && timesCalled<400)
            {
                if (Timer > 2.8f)
                {
                    trans.transform.localScale = new Vector3(8.108f, 5.405f, 0);
                    anim.ResetTrigger("transitionopen");
                    anim.SetTrigger("transitionclose");
                    Timer = 0;
                    time = false;
                }
            }
            else if(timesCalled>400)
            {
               
                
                    trans.transform.localScale = new Vector3(18, 12, 0);
                    anim.ResetTrigger("transitionopen");
                    anim.SetTrigger("transitionclose");
                    timesCalled = 0;
                
                
            }
            
            
        }
    }
    public void starttrans()
    {

            timesCalled = 250;
            bool working = false;
        

        if(300<timesCalled)
        {
            if (Input.GetKeyDown("e"))
            {
                Debug.Log("works");
                time = true;
                Timer = 0;
                anim.SetTrigger("transitionopen");
                anim.ResetTrigger("transitionclose");
                timesCalled = 401;
            }
        } else if(working==true)
        {
            time = true;
            anim.SetTrigger("transitionopen");
            anim.ResetTrigger("transitionclose");
            timesCalled = 351;
            working = false;
        }
    
    }
}
