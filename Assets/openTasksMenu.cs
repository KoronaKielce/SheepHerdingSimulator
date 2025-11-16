using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openTasksMenu : MonoBehaviour
{


    public SpriteRenderer rend;
    public Sprite newsprite;
    public Sprite oldsprite;
    public GameObject Tasks;
    public GameObject moneyButton;
    public GameObject taskClose;
    public GameObject whistleButton;
    public bool clicked = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
     void Update()
    {
       /* if(clicked == true)
        {
            
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
            
            if (hit.collider.name == this.gameObject.name)
            {
                clicked = true;
                
            }
        }*/
            rend = gameObject.GetComponent<SpriteRenderer>();
    }
    public void OnMouseOver()
    {
        rend.sprite = newsprite;
    }
    public void OnMouseExit()
    {
        rend.sprite = oldsprite;
    }
    public void OnDisable()
    {
        rend.sprite = oldsprite;
    }
    public void OnMouseDown()
    {
        taskClose.SetActive(true);
        moneyButton.SetActive(true);
        Tasks.SetActive(true);
        whistleButton.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
