using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate : MonoBehaviour
{
    public GameObject yesButton;
    public GameObject nobutton;
    public GameObject whiteSquare;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BeginBlur()
    {
        whiteSquare.SetActive(true);
        yesButton.SetActive(true);
        nobutton.SetActive(true);
    }
    public void EndBlur()
    {
        whiteSquare.SetActive(false);
        yesButton.SetActive(false);
        nobutton.SetActive(false);
    }
}
