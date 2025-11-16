using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onmouseoverchangesprite_meal : MonoBehaviour
{
    public SpriteRenderer rend;
    public Sprite newsprite;
    public Sprite oldsprite;
    public GameObject Panel;
    public Transform spawnPlaceTrans;
    public GameObject Prefab;
    public GameObject mask;
    public GameObject player;
    public GameObject spawnPlace;
    public GameObject yesButton;
    GameObject newPrefab;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = oldsprite;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseOver()
    {
        rend.sprite = newsprite;
        print("ya");
    }
    public void OnMouseExit()
    {
        rend.sprite = oldsprite;
    }
    public void OnMouseDown()
    {



        GameObject prefabChild = Instantiate(Prefab, spawnPlaceTrans.position, Quaternion.identity);

        prefabChild.transform.parent = spawnPlaceTrans;
        Panel.SendMessage("BeginBlur", 5f);
        mask.SendMessage("BeginBlur");
        player.SendMessage("BeginBlur");
        spawnPlace.SendMessage("BeginBlur");
        yesButton.SendMessage("BeginBlur", Prefab);

    }
    public void EndBlur()
    {
        Destroy(gameObject);
    }
}


