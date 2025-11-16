using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SunSameScreenPos : MonoBehaviour
{
     Camera cam;
    Vector3 screenPos;
    public float xAdd;
    public float yAdd;
    public float area;
    public Sprite moon;
    public Sprite sun;
    public bool changeSunMoon = false;
    public int change1;
    public GameObject Time;
    public bool sunUp = false;
    public bool speedTime = false;
    public GameObject Bed;
    public TIme timeKeeper;
    public maincharctermovement removeEnergy;
    public int timesSlept = 0;
    public GameObject Dialogue;
    private static GameObject instance;
    public string targetSceneName = "introsequencescene";
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
        // Start is called before the first frame update
        void Start()
    {
        timeKeeper = GameObject.Find("Time").GetComponent<TIme>();
        screenPos = cam.WorldToScreenPoint(gameObject.transform.position);
        area = -0.0001f;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (xAdd > 995)//maybe make this a bit higher so that sun doesnt immediately come up after moon
            {

                if (gameObject.GetComponent<SpriteRenderer>().sprite == moon)
                {
                    //changeSunMoon = true;
                    Time.SendMessage("New_Day");
                    gameObject.GetComponent<SpriteRenderer>().sprite = sun;
                    xAdd = -1078;
                    yAdd = 0;
                    sunUp = true;
                }
                else if (gameObject.GetComponent<SpriteRenderer>().sprite == sun)
                {

                    gameObject.GetComponent<SpriteRenderer>().sprite = moon;
                    xAdd = -1078;
                    yAdd = 0;
                    sunUp = false;
                }




            }



            //found this by  checking speed needed for sunto cross half of screen in 6 seconds, then divided that number(2.6) by 360(seconds in 6 minutes)//edit: did it somep other way Ip think
            //Time based on movement of sun starting position plus ending position equals time to move in one half day
            if (speedTime == true)
            {
                xAdd += 0.75f;
                if (timeKeeper.dayTime > 2200)
                {
                    Bed.SendMessage("Night_Over");
                    removeEnergy.playerEnergy += 10000;
                    if (timesSlept == 1)
                    {
                        Dialogue.SendMessage("Player_Wake_Up");
                    }
                    speedTime = false;
                }
            }
            else
            {
                xAdd += 0.0468222f;
            }
            print(xAdd + "hhh");
            Time.SendMessage("Space_Time", xAdd);
            yAdd = (xAdd * xAdd) * area + 175;
            cam = UnityEngine.Camera.main;
            gameObject.transform.position = cam.ScreenToWorldPoint(screenPos);

            print(gameObject.transform.position.x);

            screenPos = new Vector3(xAdd + 988, yAdd + 800, 0);

        
    }
    public void Speed_Up_Time()
    {
        timesSlept++;
        speedTime = true;
    }
}