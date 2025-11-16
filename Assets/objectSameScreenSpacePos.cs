using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSameScreenSpacePos : MonoBehaviour
{
    public Transform UI;
    public Camera cam;
    public float size;
    float propScale;
    Vector3 screenPos;
    // Start is called before the first frame update
    void Start()
    {
         screenPos = cam.WorldToScreenPoint(UI.position);
    }

    // Update is called once per frame
    void Update()
    {  
        cam = UnityEngine.Camera.main;
        UI.position = cam.ScreenToWorldPoint(screenPos);

        propScale = size / 3.95f;
        UI.localScale =new Vector3(propScale* cam.orthographicSize,propScale* cam.orthographicSize, 0);
    }
}
