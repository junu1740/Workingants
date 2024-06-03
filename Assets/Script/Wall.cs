using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [Header("Wall")]
    public GameObject Wall1;
    public GameObject WallTri;

    

    private float WallCount = 3f;

    private void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Wall1.SetActive(true);
        WallTri.SetActive(false);
       
        WallCount -= Time.deltaTime;

        if(WallCount <= 0)
        {
            Debug.Log("1");
        }





    }

    
}
