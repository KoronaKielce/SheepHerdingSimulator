using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
//using UnityEngine.Experimental.Rendering.LWRP;

public class TIme : MonoBehaviour
{
    public float dayTime = 370; //0
    public float day = 0;
    public Light2D globalLight;
    public GameObject houseLayer;
    public Sprite houseLightsOn;
    public Sprite houseLightsOff;
    public Light2D StoreLight;
    public Light2D HouseLight1;
    public Light2D HouseLight2;
    public SunSameScreenPos moonPos;
    public GameObject Calendar;
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
        moonPos = GameObject.Find("Moon").GetComponent<SunSameScreenPos>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "playscene")
        {
            Calendar.BroadcastMessage("GetDay", day);
        }
        
        if (moonPos.sunUp == true)
        {
            dayTime = moonPos.xAdd + 1078 + 2073;
        }
        else
        {
            dayTime = moonPos.xAdd + 1078;
        }
        if (0<dayTime && dayTime<2073)
        {
            if (globalLight.intensity > 0.015f)  //0.25
            {
                globalLight.intensity -= 0.0005f;
                StoreLight.intensity = 0.52f;
                HouseLight1.intensity = 0.52f;
                HouseLight2.intensity = 0.52f;
                houseLayer.GetComponent<SpriteRenderer>().sprite = houseLightsOn;
            }
        }
       
        if (2073 < dayTime)
        {
            if (globalLight.intensity < 1f)
            {
                globalLight.intensity += 0.0005f;
                
                StoreLight.intensity = 0;
                HouseLight1.intensity = 0;
                HouseLight2.intensity = 0;
                houseLayer.GetComponent<SpriteRenderer>().sprite = houseLightsOff;
            }
        }
       
    }

   
    public void New_Day()
    {
        day = day + 1;
        Calendar.SendMessage("NewDay", day);
    }
}
