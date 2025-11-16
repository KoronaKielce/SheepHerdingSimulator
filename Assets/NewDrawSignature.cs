using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDrawSignature : MonoBehaviour
{
    private LineRenderer Line;
   
    private Vector3 previousPosition;
    [SerializeField]
    private float minDistance = 0.1f;
    private LineRenderer lRend;
   public bool dontDraw = false;
    // Start is called before the first frame update
    void Start()
    {
        Line = GetComponent<LineRenderer>();

        Line.positionCount = 1;
        previousPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

       

            print(Line.positionCount + "gg");
            if (dontDraw == false)
            {
                Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                currentPosition.z = 0f;
                if (Vector3.Distance(currentPosition, previousPosition) > minDistance)
                {
                    if (previousPosition == transform.position)
                    {
                        Line.SetPosition(0, currentPosition);
                    }
                    else
                    {
                        Line.positionCount++;
                        Line.SetPosition(Line.positionCount - 1, currentPosition);
                    }

                    previousPosition = currentPosition;
                }
            
        }
     
       // Line.positionCount++;
    }
    public void stop_Drawing()
    {
        dontDraw = true;
    }
}
