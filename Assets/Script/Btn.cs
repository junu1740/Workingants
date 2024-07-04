using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn : MonoBehaviour
{
    public GameObject Name_UI;
    public GameObject Ant;
    public GameObject Timer;
    public void Start()
    {
       
    }
    public void Main()
    {
        Name_UI.SetActive(false);
        Timer.SetActive(true);
        Ant.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene("Main");
    }

    public void Exit()
    {
       Application.Quit();
    }

    public void Home()
    {
        SceneManager.LoadScene("Start");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        SceneManager.LoadScene("Goal");
        
        
    }



}
