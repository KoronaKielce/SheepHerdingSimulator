using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class ToTrail : MonoBehaviour
{
    public GameObject Player;
    public Transform Sheep;
    Vector3 playerPos;
    Vector3 playerPos2;
    private static GameObject instance;
    Camera cam;
    public bool change1 = false;
    public bool change2 = false;
    public GameObject spriteManagement;
    public int sheepFollowingAmount = 0;
    public int timesChanged = 0;
    public GameObject dialogueBox;
    public GameObject Dialogue;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void Awake()
    {

        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = gameObject;
        }
        else
        {
            Destroy(gameObject);

        }
        cam = Camera.main;
    }
        // Update is called once per frame
        void Update()
    {
        
       
        if (SceneManager.GetActiveScene().name == "Trail Scene" && change1 == true)
        {
            sheepFollowingAmount = 0;
            Player.transform.position = new Vector3(-36f, -3.5f, 0);
            for (int i = 0; i < spriteManagement.transform.childCount; i++)
            {
                Sheep = spriteManagement.transform.GetChild(i);
                if (Sheep.name.ToLower().Contains("sheep(clone)") & Sheep.transform.position.y < -1.52f){
                    sheepFollowingAmount++;
                    Sheep.transform.position = new Vector3(Random.Range(-36.5f, -39f), Random.Range(-4.41f, -3.187f), 0);
                }
            }
            
            change1 = false;
        }
        else if (SceneManager.GetActiveScene().name == "playscene" && change2 == true)
        {
            Player.transform.position = new Vector3(9.38f, -2.48f, 0);
            for (int i = 0; i < spriteManagement.transform.childCount; i++)
            {
                Sheep = spriteManagement.transform.GetChild(i);
                if (Sheep.name.ToLower().Contains("sheep(clone)")){
                    Sheep.transform.position = new Vector3(Random.Range(9.52f, 12.5f), Random.Range(-2.95f, -1.8f), 0);
                }
            }
           
            change2 = false;

        }
        Player = GameObject.Find("player");
        if (SceneManager.GetActiveScene().name == "playscene" && Player.transform.position.y > -3f)
        {
            if (Player.transform.position.x > 11.35f)
            {
                Dialogue.layer = LayerMask.NameToLayer("Default");
                dialogueBox.layer = LayerMask.NameToLayer("Default");

                timesChanged++;
                SceneManager.LoadScene(3); //-38.37999
                change1 = true;
                if(timesChanged == 1)
                {
                    Dialogue.SendMessage("enteredTrailhead");
                }
            }
        }
        else if (SceneManager.GetActiveScene().name == "Trail Scene")
        {
            if (Player.transform.position.x < -38.37999f)
            {
                
                SceneManager.LoadScene(2);
                change2 = true;
               
                
            }
        }
       

    }
}
