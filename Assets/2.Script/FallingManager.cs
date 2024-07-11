using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingManager : MonoBehaviour
{
    public GameObject Falling;
    public static FallingManager Instance;
    
    private bool isCoroutineRunning = false;


    private void Awake()
    {
        Instance = this;
    }
    public void disappear()
    {
       StartCoroutine(DisappearAndReappear());

    }

    public IEnumerator DisappearAndReappear()
    {
        yield return new WaitForSeconds(2f);
        isCoroutineRunning = true;
        Falling.SetActive(false);  // ���� ������Ʈ ��Ȱ��ȭ

        yield return new WaitForSeconds(3f);  // �߰������� 3�� ���

        Falling.SetActive(true);  // ���� ������Ʈ �ٽ� Ȱ��ȭ
        isCoroutineRunning = false;
    }
}
