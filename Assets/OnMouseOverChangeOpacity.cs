using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnMouseOverChangeOpacity : MonoBehaviour
{
    public string trailName;
    public GameObject trailQuest;
    public GameObject spawn;
    public SpriteRenderer rend;
    public Text txt;
    public string matchDay;
    public int spawnOnce = 0;
    public string randHourHere;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
    }
    public void OnMouseOver()
    {
        rend.color = new Color(255, 255, 255, 255);
    }
    public void OnMouseExit()
    {
        rend.color = new Color(255, 255, 255, 0);
    }
    public void OnMouseDown()
    {
        if (string.Equals("Day" + matchDay, this.gameObject.transform.name)){
            if (spawnOnce == 0)
            {
                GameObject Task = Instantiate(trailQuest);
                Task.transform.SetParent(spawn.transform);
                Task.transform.localScale = new Vector3(0.9434292f, 4.546017f, 1);
                Task.transform.localPosition = new Vector3(0, 0, 0);
                Task.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = trailName + " for     hours";
                Task.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(randHourHere);
                spawnOnce += 1;
            }
        }
       
    }
    public void Name(string trailNameForeign)
    {
        trailName = trailNameForeign;
    }
    public void GetDay(float day)
    {
        matchDay = day.ToString();
    }
    public void GetRandHour(string randHour)
    {
        randHourHere = randHour;
    }
}
