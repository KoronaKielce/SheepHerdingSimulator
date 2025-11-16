using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recipechangesprite : MonoBehaviour
{
    public SpriteRenderer rend;
    public float page;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        page =  GameObject.Find("right arrow").GetComponent<Recipebookpagechange>().page;
        if( page == 0)
        {
            rend.sprite = one;
        }
        else if (page == 1)
        {
            rend.sprite = two;
        }
        else if (page == 2)
        {
            rend.sprite = three;
        }
        else if (page == 3)
        {
            rend.sprite = four;
        }
    }
}
