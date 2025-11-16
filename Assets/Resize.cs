using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    GameObject obj;
   public Vector3 scale = new Vector3();
   public Vector3 rotation = new Vector3();
    public Vector3 Secondscale = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        if (gameObject.transform.parent.tag == "mainInv")
        {
            obj.transform.localScale = scale;
            obj.transform.localRotation = Quaternion.Euler(rotation);
        }
        if (gameObject.transform.parent.tag == "inventory")
        {
          
            obj.transform.localScale = Secondscale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        obj = gameObject;
        if (gameObject.transform.parent.tag == "mainInv")
        {
            obj.transform.localScale = scale;
            obj.transform.localRotation = Quaternion.Euler(rotation);
        }
        if (gameObject.transform.parent.tag == "inventory")
        {

            obj.transform.localScale = Secondscale;
        }
    }
}
