using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingManager : MonoBehaviour
{
    public GameObject Falling;
    public static FallingManager Instance;
    
    private bool isCoroutineRunning = false;
    public void disappear()
    {
       StartCoroutine(DisappearAndReappear());

    }

    IEnumerator DisappearAndReappear()
    {
        yield return new WaitForSeconds(2f);
        isCoroutineRunning = true;
        gameObject.SetActive(false);  // ���� ������Ʈ ��Ȱ��ȭ

        yield return new WaitForSeconds(3f);  // �߰������� 3�� ���

        gameObject.SetActive(true);  // ���� ������Ʈ �ٽ� Ȱ��ȭ
        isCoroutineRunning = false;
    }
}
