using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipebookpagechangenegative : MonoBehaviour
{
    
    public float pagechangeback;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
     void OnMouseDown()
    {
        
        if(pagechangeback > 0)
        {
            pagechangeback--;
        }
        GameObject.Find("right arrow").GetComponent<Recipebookpagechange>().page = pagechangeback;
    }
}
