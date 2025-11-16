using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public Camera cam;
    public Transform subject;
    float distancefromsubject => transform.position.z - subject.position.z;
    float clippingplane => (cam.transform.position.z + (distancefromsubject > 0? cam.farClipPlane: cam.nearClipPlane));
    Vector2 startposition;
    float parallaxFactor => Mathf.Abs(distancefromsubject) / clippingplane;
    float startz;
    Vector2 travel => (Vector2)cam.transform.position - startposition;
    Vector2 ParallaxFactor;
    // Start is called before the first frame update
   public void Start()
    {
        subject = GameObject.Find("player").transform;
        startposition = transform.position;
        startz = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = startposition + travel * parallaxFactor;
        transform.position = new Vector3(newPos.x, newPos.y, startz);
    }
}
