
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingSystem : MonoBehaviour
{
    [Header("Best")]
    public Text BestScore_;
    public Text BestName_;

    [Header("Best")]
    public Text CurrentScore_;
    public Text CurrentName_;

    private Text TimeScore;
    private float CurrentScore;
    private float BestScore;

    private void Start()
    {
       TimeScore = Timer.Instance.timeTxt;
        CurrentName_.text = PlayerPrefs.GetString("Name");

            CurrentScore_.text = TimeScore.text;

    }

    private void Update()
    {
        if (Timer.Instance.Time <= Timer.Instance.besttime)
        {
            BestScore_.text = TimeScore.text;
            BestName_.text = PlayerPrefs.GetString("Name");
            Timer.Instance.besttime = Timer.Instance.Time;
        }
       
    }
}


