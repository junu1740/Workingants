using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Btn : MonoBehaviour
{
    public GameObject Name_UI;
    public GameObject Ant;
    public GameObject Timer_;
    public Text IDTxt;

    

  
    public void Main()
    {
        Name_UI.SetActive(false);
        Timer_.SetActive(true);
        Ant.SetActive(true);
        PlayerPrefs.SetString("Name", IDTxt.text);
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
   



}
