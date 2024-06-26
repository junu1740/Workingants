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
        gameObject.SetActive(false);  // 게임 오브젝트 비활성화

        yield return new WaitForSeconds(3f);  // 추가적으로 3초 대기

        gameObject.SetActive(true);  // 게임 오브젝트 다시 활성화
        isCoroutineRunning = false;
    }
}
