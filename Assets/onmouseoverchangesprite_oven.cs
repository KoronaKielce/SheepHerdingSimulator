using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onmouseoverchangesprite_oven : MonoBehaviour
{
    public SpriteRenderer rend;
public Sprite newsprite;
public Sprite oldsprite;
    public Sprite ovenCooking;
public GameObject Panel;
public Transform spawnPlaceTrans;
public GameObject Prefab;
public GameObject mask;
public GameObject player;
public GameObject spawnPlace;
public GameObject yesButton;
GameObject newPrefab;
public GameObject book;
    public GameObject whitesquare;
    public GameObject leftArrow;
    public GameObject rightArrow;
    public GameObject menu;
    public bool timerDown2;
// Start is called before the first frame update
void Start()
{
    GameObject newPrefab = Prefab;
}

// Update is called once per frame
void Update()
{

}
public void OnMouseOver()
{
        if (timerDown2 == true)
        {
            rend.sprite = ovenCooking;
        }
        else
        {
            rend.sprite = newsprite;
        }
}
public void OnMouseExit()
{

        if (timerDown2 == true)
        {
            rend.sprite = ovenCooking;
        }
        else
        {
            rend.sprite = oldsprite;
        }
}
public void OnMouseDown()
{
    book.SetActive(true);
        whitesquare.SetActive(true);
     leftArrow.SetActive(true);
        rightArrow.SetActive(true);
        menu.SetActive(true);


        Panel.SendMessage("BeginBlur", 5f);
    mask.SendMessage("BeginBlur");
    player.SendMessage("BeginBlur");
    spawnPlace.SendMessage("BeginBlur");
    

}
public void EndBlur()
{
        book.SetActive(false);
        whitesquare.SetActive(false);
        leftArrow.SetActive(false);
        rightArrow.SetActive(false);
        menu.SetActive(false);
    }
    public void cookinOn(bool timerDown)
    {
        print(timerDown + "skr");
        if (timerDown == true)
        {
            
            timerDown2 = timerDown;
        }
    }
   public void cookinOff(bool timerDown)
    {
        if (timerDown == false)
        {

            timerDown2 = timerDown;
            rend.sprite = oldsprite;
        }
    }
}

