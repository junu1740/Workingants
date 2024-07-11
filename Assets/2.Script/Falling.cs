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
        gameObject.SetActive(false);  // ���� ������Ʈ ��Ȱ��ȭ
        Invoke("Appear", 3f);
    }

    private void Appear()
    {
        gameObject.SetActive(true);  // ���� ������Ʈ �ٽ� Ȱ��ȭ
        isCoroutineRunning = false;
    }
}

  
