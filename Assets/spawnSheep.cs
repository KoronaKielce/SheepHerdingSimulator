using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;
public class spawnSheep : MonoBehaviour
{
    public GameObject Sheep;
    public float color;
    public List<float> height;
    public float playerHeight;
    public int allSheepOutFirstTime = 0;
    public int sheepOutNbr = 0;
    public GameObject Dialogue;
    private static GameObject instance;
    // Start is called before the first frame update
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
    }
    void Start()
    {
        for (int i=0;i < 20; i++)
        {
            GameObject newSheep = Instantiate(Sheep, new Vector2(Random.Range(3.2f, -4.05f), -1.52f), transform.rotation);
            SpriteRenderer newSheepRend = newSheep.GetComponent<SpriteRenderer>();
            newSheepRend.sortingOrder = i;
            color = Random.Range(0.72f, 1);
            newSheepRend.color = new Color(color, color, color, 1);
            newSheep.transform.parent = this.gameObject.transform;
            newSheep.name = newSheep.name + i.ToString();
        }
        //  foreach (Transform child in transform)
        //  {
        //    children.Add(child);
        //  }
        height = new List<float>();
        for (int i = 0; i < transform.childCount; i++)
        {          
            Transform tform = transform.GetChild(i);
            height.Add(tform.transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(allSheepOutFirstTime == 0)
        {
            for(int i = 0; i < height.Count; i++)
            {
                if (height[i] < -1.78f)
                {
                    sheepOutNbr+= 1;
                }
            }
            if(sheepOutNbr == 21)
            {
                Dialogue.SendMessage("Sheep_Left_Pen");
                allSheepOutFirstTime = 1;
            }
            else
            {
                sheepOutNbr = 0;
            }
        }
        playerHeight = GameObject.Find("player").transform.position.y - 0.35f;
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).name == "player")
            {
                height[i] = playerHeight;
            }
            else
            {
                height[i] = transform.GetChild(i).transform.position.y;
            }
           // height.Sort(height[i]);
        }
        height.Sort();
        for (int i = 0; i < height.Count; i++)
        {
            for(int j = 0; j<height.Count;)
            {
                if(transform.GetChild(j).name == "player" && playerHeight == height[i])
                {
                    transform.GetChild(j).GetComponent<SpriteRenderer>().sortingOrder = height.Count - i + 2;
                    print("cowxool");
                    
                }
                else if (transform.GetChild(j).transform.position.y == height[i])
                {
                    transform.GetChild(j).GetComponent<SpriteRenderer>().sortingOrder = height.Count - i + 2;
                    
                }
                j++;
            }
        }
        
        
    }
}
