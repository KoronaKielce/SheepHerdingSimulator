using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOverButton : MonoBehaviour
{
    public Sprite newSprite;
    public Sprite oldSprite;
    public SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend.sprite = oldSprite;
    }

    // Update is called once per frame
    void Update()
    {
       
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
        rend.sprite = oldSprite;
    }
}
