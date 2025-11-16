using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovenCook : MonoBehaviour
{
    public SpriteRenderer rend;
    public Sprite ovenCooking;                                                 
    public ovenTimerCountDown count;
    public bool timerDown;
    public float timeSet;
    public GameObject Timer;
    ParticleSystem particles;
    public GameObject meal;
    public Transform mealSpawn;
    public onmouseoverchangesprite_oven over;
    public float cookAmount = 0;
    public GameObject Dialogue;
    public GameObject newMeal;
    // Start is called before the first frame update
    void Start()
    {
        particles = GetComponent<ParticleSystem>();
        particles.Stop();
    }

    // Update is called once per frame
    public void Update()
    {
        
        print(timerDown);
      //  timerDown = true;
        if (timerDown == true)
        {

            print("ok2"); 
            timeSet -= Time.deltaTime;
            
            if (timeSet <= 0)
            {
                if (particles.isPlaying)
                {
                    print("particleswork");
                    particles.Stop();
                }
                Timer.SetActive(false);
                GameObject mealClone = Instantiate(meal, mealSpawn.position, transform.rotation);
                mealClone.name = meal.name;
                mealClone.transform.parent = mealSpawn;
                cookAmount++;
                if (cookAmount == 1)
                {
                    Dialogue.SendMessage("Done_Cooking");
                   newMeal = GameObject.Find("meal");
                    newMeal.SendMessage("Done_Cooking");
                }
                timerDown = false;
                over.cookinOff(timerDown);
                timeSet = 0;
            }
            count.CountDown(timeSet);
        }
        
    }
    public void Cook(bool preTimerDown, float preTimeSet)
    {
        if (preTimeSet > 1 && preTimerDown == true)
        {
            print(preTimerDown + "kr");
            timerDown = preTimerDown;
            print(preTimeSet + "br");
            timeSet = preTimeSet;
        }
       
    }
    public void Appearance(bool mouseDown)
    {
        if (mouseDown)
        {
            Timer.SetActive(true);
            rend.sprite = ovenCooking;
            if (!particles.isPlaying)
            {
                particles.Play();
            }
        }
        
    }
}
