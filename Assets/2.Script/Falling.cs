using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    private bool isCoroutineRunning = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("DisappearAndReappear", 2f);
        }
    }

    private void DisappearAndReappear()
    {
        isCoroutineRunning = true;
        gameObject.SetActive(false);  // 게임 오브젝트 비활성화
        Invoke("Appear", 3f);
    }

    private void Appear()
    {
        gameObject.SetActive(true);  // 게임 오브젝트 다시 활성화
        isCoroutineRunning = false;
    }
}

  
