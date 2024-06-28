using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public Text time;
    private float sec;
    private float min;



    private void Start()
    {
    }

    private void Update()
    {
       time.text = $"{min}:{sec}";
        sec += Time.deltaTime;
        if(sec >= 59)
        {
            min += 1;
            sec = 0;
        }

    }
}
