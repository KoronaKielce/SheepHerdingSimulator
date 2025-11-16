using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeTaskMenu : MonoBehaviour
{
    public GameObject Task;
    public GameObject Money;
    public GameObject taskOpen;
    public GameObject whistleButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        Task.SetActive(false);
        Money.SetActive(false);
        whistleButton.SetActive(false);
        taskOpen.SetActive(true);
        gameObject.SetActive(false);
    }
}
