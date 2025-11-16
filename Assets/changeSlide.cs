using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changeSlide : MonoBehaviour
{
    public int clicks;
    public SpriteRenderer rend;
    public Sprite Money;
    public Sprite Globe;
    public Sprite Plane;
    public Text _text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clicks++;
        }   
        if(clicks == 1)
        {
            _text.text = "You were rich too..."; 
            rend.sprite = Money;
        }
        if (clicks == 2)
        {
            _text.text = "But you yearned to return to your homeland";
            rend.sprite = Globe;
        }
        if (clicks == 3)
        {
            _text.text = "and so you boarded the next plane heading to the east...";
            rend.sprite = Plane;
        }
        if (clicks == 4)
        {
            SceneManager.LoadScene(2);
        }
        }
}
