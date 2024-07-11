using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public static Goal Instance;

    public void Update()
    {


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //if (Timer.Instance.tim <= Timer.Instance.besttime)

        Debug.Log($"Goal ::: time : {TimerManager.instance.Time}");
        Debug.Log($"Goal ::: besttime : {TimerManager.instance.besttime}");
        SceneManager.LoadScene("Goal");

    }

}
