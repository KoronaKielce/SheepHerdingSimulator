using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class changeIntensity : MonoBehaviour
{
    public Light2D moonSunLight;
    public GameObject moonSun;
    public Sprite moon;
    public Sprite sun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moonSun.GetComponent<SpriteRenderer>().sprite == moon)
        {
            moonSunLight.intensity = 0.15f;
        }
        else
        {
            /* moonSunLight.intensity = 10.93f;
             moonSunLight.pointLightInnerRadius = 0.38f;
             moonSunLight.pointLightOuterRadius = 3.49f;
             moonSunLight.falloffIntensity = 0.362f;
             moonSunLight.volumeIntensity = 0.05f;
             moonSunLight.shadowIntensity = 0.337f;*/
            moonSunLight.intensity = 0.3f;
        }
    }
}
