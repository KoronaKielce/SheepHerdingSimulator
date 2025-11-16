using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ovenTimerCountDown : MonoBehaviour
{
    public Slider slider;

    public void CountDown(float Time)
    {
       
        slider.value = Time;
    }
    public void CountDownAmount(float Time)
    {
        print(Time +"herez");
        slider.maxValue = Time;
        slider.value = Time;
    }
}
