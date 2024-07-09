using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

public class Goal : MonoBehaviour
{
    public static Goal Instance;

    public void Update()
    {
        
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        SceneManager.LoadScene("Goal");
        
        
    }

}
