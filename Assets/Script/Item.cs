using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
      if(gameObject.tag == "Jump")
        {
            PMove.instance.jumpCount += 1;
        }

        }
        
    }
}
