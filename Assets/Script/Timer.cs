using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    private float sec;
    private float min;

    public Text time;

    private void Start()
    {
    }

    private void Update()
    {
       time.text = $"{min}:{sec}";
        sec += UnityEngine.Time.deltaTime;
        if(sec >= 59)
        {
            min += 1;
            sec = 0;
        }

    }
}
