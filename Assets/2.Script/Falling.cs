using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{


    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FallingManager.Instance.disappear();
    }
}
