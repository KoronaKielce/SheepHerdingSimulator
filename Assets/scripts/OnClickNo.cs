using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Rendering;

public class OnClickNo : MonoBehaviour
{
    public GameObject Panel;
    public GameObject player;
    public GameObject mask;
    public GameObject spawnPlace;
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
        GameObject Dialogue = GameObject.Find("sheep_dialogue");
        GameObject dialogueButton = GameObject.Find("sheep_Dialogue_Button");
        Dialogue.gameObject.layer = 0;
        dialogueButton.gameObject.layer = 0;
        GameObject.Find("Main Camera").GetComponent<Volume>().weight = 0;
        GameObject.Find("Main Camera").GetComponent<Camera>().depth = 1;
        GameObject UI = GameObject.Find("UI");
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

                            child2.transform.GetChild(k).gameObject.layer = 0;
                        }
                    }
                    child1.transform.GetChild(j).gameObject.layer = 0;
                }
            }
            UI.transform.GetChild(i).gameObject.layer = 0;
        }

        spawnPlace.BroadcastMessage("EndBlur");
        mask.SendMessage("EndBlur");
        player.SendMessage("EndBlur");
      
     
       
    }
}
