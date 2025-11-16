using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcharcater : MonoBehaviour
{
   
    public Transform TrackingTarget;
    public float time = 0;

    public bool follow = true;
    public float pos_X;
    public float neg_X;
    public void intohouse()
    {
        follow = false;
    }
    public void outofhouse()
    {
        time += Time.deltaTime;
        if (time >= 1)
        {
            follow = true;
            time = 0;
        }
    }

    public void intoShop()
    {
        follow = false;
    }
    public void outOfShop()
    {
        follow = true;
    }
    public void Awake()
    {
        TrackingTarget = GameObject.Find("player").transform;
    }
    public void Start()
    {
        if (TrackingTarget.position.x < neg_X)
        {
            transform.position = new Vector3(neg_X, 0, 0);
        }
        if (TrackingTarget.position.x > pos_X)
        {
            transform.position = new Vector3(pos_X, 0, 0);
        }
    }
   
    // Update is called once per frame
    void Update()
    {


        
        if (follow == true)
        {
            if (TrackingTarget.position.x > neg_X && TrackingTarget.position.x < pos_X)
            {
                transform.position = new Vector3(TrackingTarget.position.x,
                   0, 0);
            }
            else
            {   //try to change this in the future so its one line
               if(TrackingTarget.position.x < neg_X)
                {
                    transform.position = new Vector3(neg_X, 0, 0);
                }
                if (TrackingTarget.position.x > pos_X)
                {
                    transform.position = new Vector3(pos_X, 0, 0);
                }
            }
        }
        else
        {

        }

            }
        }
  
       
    





