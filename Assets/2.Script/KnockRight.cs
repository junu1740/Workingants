using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockRight : MonoBehaviour
{
    private Rigidbody2D rigid;

    private void Start()
    {
        // Start 메서드에서 한 번만 Rigidbody2D 컴포넌트를 가져오도록 수정
        rigid = GetComponent<Rigidbody2D>();
    }

    // 충돌체에 들어갈 때 호출되는 메서드
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Right_Fork")
        {
            StartCoroutine(KnockBack(10));
            StartCoroutine(KnockDown(10));
        }


    }

    // 넉백을 처리하는 코루틴 메서드
    private IEnumerator KnockBack(float power)
    {
        // Rigidbody2D가 null인지 확인
        if (rigid == null)
        {
            Debug.LogWarning("Rigidbody2D 컴포넌트를 찾을 수 없습니다.");
            yield break; // 코루틴 종료
        }

        // 초기 속도를 0으로 설정
        rigid.velocity = Vector2.zero;

       
        Vector2 knockbackDirection = Vector2.right;

        // power가 0 이상인 동안 반복
        while (power >= 0)
        {
            // Rigidbody에 넉백 방향과 power를 곱한 값을 속도로 설정
            rigid.velocity = knockbackDirection * power;

            // 매우 짧은 시간 동안 대기
            yield return new WaitForSeconds(0.0001f);

            // power 감소
            power -= 0.1f;
        }

        // 추가적으로 yield return null;을 사용하여 명시적으로 코루틴 종료
        yield return null;
    }
    private IEnumerator KnockDown(float power)
    {
        // Rigidbody2D가 null인지 확인
        if (rigid == null)
        {
            Debug.LogWarning("Rigidbody2D 컴포넌트를 찾을 수 없습니다.");
            yield break; // 코루틴 종료
        }

        // 초기 속도를 0으로 설정
        rigid.velocity = Vector2.zero;

        // power가 0 이상인 동안 반복
        while (power >= 0)
        {
            // Rigidbody에 넉백 방향과 power를 곱한 값을 속도로 설정
            rigid.velocity = Vector2.down * power;

            // 매우 짧은 시간 동안 대기
            yield return new WaitForSeconds(0.0001f);

            // power 감소
            power -= 0.1f;
        }

        // 추가적으로 yield return null;을 사용하여 명시적으로 코루틴 종료
        yield return null;
    }
}
