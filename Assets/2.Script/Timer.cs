using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public static Timer Instance;
    private float sec;
    private float min;
    public float tim;

    public Text timeTxt;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
        DontDestroyOnLoad(Instance);
    }
    private void Start()
    {
    }

    private void Update()
    {
        timeTxt.text = $"{min}:{sec:N2}";
        sec += UnityEngine.Time.deltaTime;
        tim += UnityEngine.Time.deltaTime;
        TimerManager.instance.Time = tim;
        if (sec >= 59)
        {
            min += 1;
            sec = 0;
        }
    }
}
