using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepBottomRight : MonoBehaviour
{
    public GameObject mainUI;
    public Vector3 screenPosition = new Vector3(0, 0, 20);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainUI.transform.position = screenPosition;
    }
}
