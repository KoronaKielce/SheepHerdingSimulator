    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyparticle : MonoBehaviour
{
    
    public GameObject player;
   ParticleSystem particles;
    Vector3 lastPos;
    
    
    
     
    // Start is called before the first frame update
    void Start()
    {

        particles = GetComponent<ParticleSystem>();
       
    }
    void Update()
    {

        
        if (lastPos != player.transform.position)
        {



            if (!particles.isPlaying) particles.Play();




        }
        else if (particles.isPlaying)
        {

            particles.Stop();


        }
        lastPos = player.transform.position;

        
    }
    // Update is called once per frame
   


}
