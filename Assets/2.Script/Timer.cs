using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    private float time;
    public static Timer Instance;
    private float sec;
    private float min;

    public Text timeTxt;


    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
    }

    private void Update()
    {
       timeTxt.text = $"{min}:{sec:N2}";
        sec += UnityEngine.Time.deltaTime;
        if(sec >= 59)
        {
            min += 1;
            sec = 0;
        }

    }

    public void ScoreSet()
    {
        PlayerPrefs.SetFloat("Score", time);
        Debug.Log("n");

    }
    
}
