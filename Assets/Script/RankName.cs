using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RankName : MonoBehaviour
{
    public Text IDTxt;



    public void Gamestart()
    {
        PlayerPrefs.SetString("ID",IDTxt.text);

        SceneManager.LoadScene("Main");
    }
}
