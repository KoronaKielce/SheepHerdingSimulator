using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOverUI : MonoBehaviour
{
    public GameObject secondINV;
    public GameObject thirdINV;
    public GameObject fourthINV;
    public GameObject fifthINV;
    public SpriteRenderer rend;
    public Sprite newSprite;
    public Sprite oldSprite;
    public float timesClicked = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timesClicked == 2)
        {
            secondINV.SetActive(false);
            thirdINV.SetActive(false);
            fourthINV.SetActive(false);
            fifthINV.SetActive(false);
            timesClicked = 0;
        }
    }
    public void OnMouseOver()
    {
        rend.sprite = newSprite;
    }
    public void OnMouseExit()
    {
        
        rend.sprite = oldSprite;
       
    }
    public void OnMouseDown()
    {
        timesClicked++;
        rend.sprite = newSprite;
        secondINV.SetActive(true);
        thirdINV.SetActive(true);
        fourthINV.SetActive(true);
        fifthINV.SetActive(true);

    }
}
