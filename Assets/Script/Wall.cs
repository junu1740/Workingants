using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [Header("Wall")]
    public GameObject Wall1;
    public GameObject WallTri;

    private bool justWall;

    private float WallCount = 2f;

    private void Update()
    {
        IsWall();
    }
    void IsWall()
    {
        if (justWall)
        {
        WallCount -= Time.deltaTime;
            Debug.Log("1");

        if(WallCount <= 0)
        {

        }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Wall1.SetActive(true);
        WallTri.SetActive(false);
        justWall = true;

    }

    
}
