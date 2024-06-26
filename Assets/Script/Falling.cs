using System.Collections;
using UnityEngine;

public class Falling : MonoBehaviour
{
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FallingManager.Instance.disappear();
    }

    
}
