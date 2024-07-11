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
    public GameObject Setting_UI;
    public Text IDTxt;
    public Text Name_Text;



    private void Update()
    {
       
    }
    public void Main()
    {
        Name_UI.SetActive(false);
        Timer_.SetActive(true);
        Ant.SetActive(true);
        PlayerPrefs.SetString("Name", IDTxt.text);
        Name_Text.text = PlayerPrefs.GetString("Name");
    }

    public void Goal()
    {
        SceneManager.LoadScene("Goal");
        // BestTime   set
        //Tim reset
    }
    public void restart()
    {
        SceneManager.LoadScene("Main");
        Timer.Instance.tim = 0;
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
