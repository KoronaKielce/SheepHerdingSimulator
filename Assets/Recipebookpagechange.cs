using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipebookpagechange : MonoBehaviour
{
    
    public float page = 0;
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
      
        if (page < 3)
        {
            page++;
        }
        GameObject.Find("left arrow").GetComponent<Recipebookpagechangenegative>().pagechangeback = page;
    }
}
