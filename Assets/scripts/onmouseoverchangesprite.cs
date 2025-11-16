using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Rendering;

public class onmouseoverchangesprite : MonoBehaviour
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
    public bool mouseIsOver = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPrefab = Prefab;
        //remove if u get problems later (new line to make sure GO is normal when you activate it, specifically x button)
        rend.sprite = oldsprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseIsOver == true)
        {
            rend.sprite = newsprite;
        }
        else
        {
            rend.sprite = oldsprite;
        }

    }
    public void OnMouseOver()
    {

        mouseIsOver = true;
    }
    public void OnMouseExit()
    {
        mouseIsOver = false;
    }
    public void OnDisable()
    {
        mouseIsOver = false;
    }
    public void OnMouseDown()
    {


        GameObject Dialogue = GameObject.Find("sheep_dialogue");
        GameObject dialogueButton = GameObject.Find("sheep_Dialogue_Button");
        Dialogue.gameObject.layer = 6;
        dialogueButton.gameObject.layer = 6;
        GameObject prefabChild = Instantiate(Prefab, spawnPlaceTrans.position, Quaternion.identity);
        GameObject UI = GameObject.Find("UI");
        GameObject.Find("Main Camera").GetComponent<Camera>().depth = -1;
        for (int i = 0; i < UI.transform.childCount; i++)
        {

            if (UI.transform.GetChild(i).childCount > 0)
            {
                Transform child1 = UI.transform.GetChild(i);
                for (int j = 0; j < child1.transform.childCount; j++)
                {
                    if (child1.childCount > 0)
                    {
                        Transform child2 = child1.transform.GetChild(j);
                        for (int k = 0; k < child2.transform.childCount; k++)
                        {

                            child2.transform.GetChild(k).gameObject.layer = 6;
                        }
                    }
                    child1.transform.GetChild(j).gameObject.layer = 6;
        }
    }
    UI.transform.GetChild(i).gameObject.layer = 6;
        }


prefabChild.layer = 6;
        prefabChild.GetComponent<SpriteRenderer>().sortingOrder = 30;
        prefabChild.transform.parent = spawnPlaceTrans;
        // Panel.SendMessage("BeginBlur",1f);
        
        mask.SendMessage("BeginBlur");
        player.SendMessage("BeginBlur");
        spawnPlace.SendMessage("BeginBlur");
        yesButton.SendMessage("BeginBlur",Prefab);
        GameObject.Find("Main Camera").GetComponent<Volume>().weight = 1;
    }

    public void EndBlur()
    {
        Destroy(gameObject);
    }
}
