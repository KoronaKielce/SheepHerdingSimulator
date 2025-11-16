using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldAssignment : MonoBehaviour
{
    public float rand;
    public GameObject NowaWies;
    public GameObject CichaPolana;
    public GameObject JezioroJeleni;
    public GameObject BialaJama;
    public GameObject PolanaBandytow;
    public GameObject OstreSkaly;
    public GameObject DolinaMgly;
    public GameObject Smierc;
    public GameObject calDay;
    public float outerDay;
    public bool instantiate = false;
    public int randHour;
    public string randHourString;
    public Sprite childSprite;
    public GameObject bigCalendar;
    public string trailNameUpdate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject trail = null;
        calDay = GameObject.Find("Day" + outerDay);
        bigCalendar.BroadcastMessage("Name", trailNameUpdate);
        bigCalendar.BroadcastMessage("GetRandHour", randHourString);
        if(instantiate == true)
        {
            if (outerDay == 1 || outerDay == 2)
            {
                trail = Instantiate(NowaWies, calDay.transform.position, calDay.transform.rotation);
                trail.name = NowaWies.name;

            }
            if(outerDay == 3)
            {
                trail = Instantiate(CichaPolana, calDay.transform.position, calDay.transform.rotation);
                trail.name = CichaPolana.name;

            }
            if (outerDay == 4 || outerDay == 5 || outerDay == 6)
            {
                if (rand < 0.5)
                {
                     trail = Instantiate(NowaWies, calDay.transform.position, calDay.transform.rotation);
                     trail.name = NowaWies.name;
                }
                else
                {
                    trail = Instantiate(CichaPolana, calDay.transform.position, calDay.transform.rotation);
                    trail.name = CichaPolana.name;
                }
            }
            if(outerDay == 7)
            {
                trail = Instantiate(JezioroJeleni, calDay.transform.position, calDay.transform.rotation);
                trail.name = JezioroJeleni.name;
            }
            if(outerDay == 8 || outerDay == 9 || outerDay == 10 || outerDay == 11)
            {
                if (rand < 0.2)
                {
                    trail = Instantiate(NowaWies, calDay.transform.position, calDay.transform.rotation);
                    trail.name = NowaWies.name;
                }
                else if(rand < 0.55)
                {
                    trail = Instantiate(CichaPolana, calDay.transform.position, calDay.transform.rotation);
                    trail.name = CichaPolana.name;
                }
                else
                {
                    trail = Instantiate(JezioroJeleni, calDay.transform.position, calDay.transform.rotation);
                    trail.name = JezioroJeleni.name;
                }
            }
            trailNameUpdate = trail.name;
            trail.transform.parent = calDay.transform.parent;
            trail.transform.localPosition = calDay.transform.localPosition;
            trail.transform.localScale = new Vector3(1, 1, 1);
            randHourString = randHour.ToString();
            childSprite = trail.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(randHourString);
            trail.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.black;
            instantiate = false;
        }
    }
    public void NewDay(float day)
    {
       outerDay = day;
        if (outerDay == 1)
        {
            randHour = 4;
        }
        else
        {
            randHour = Random.Range(1, 15);
        }
        rand = Random.value;
        instantiate = true;
        
    }
}
