using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockRight : MonoBehaviour
{
    private Rigidbody2D rigid;

    private void Start()
    {
        // Start �޼��忡�� �� ���� Rigidbody2D ������Ʈ�� ���������� ����
        rigid = GetComponent<Rigidbody2D>();
    }

    // �浹ü�� �� �� ȣ��Ǵ� �޼���
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Right_Fork")
        {
            StartCoroutine(KnockBack(10));
            StartCoroutine(KnockDown(10));
        }


    }

    // �˹��� ó���ϴ� �ڷ�ƾ �޼���
    private IEnumerator KnockBack(float power)
    {
        // Rigidbody2D�� null���� Ȯ��
        if (rigid == null)
        {
            Debug.LogWarning("Rigidbody2D ������Ʈ�� ã�� �� �����ϴ�.");
            yield break; // �ڷ�ƾ ����
        }

        // �ʱ� �ӵ��� 0���� ����
        rigid.velocity = Vector2.zero;

       
        Vector2 knockbackDirection = Vector2.right;

        // power�� 0 �̻��� ���� �ݺ�
        while (power >= 0)
        {
            // Rigidbody�� �˹� ����� power�� ���� ���� �ӵ��� ����
            rigid.velocity = knockbackDirection * power;

            // �ſ� ª�� �ð� ���� ���
            yield return new WaitForSeconds(0.0001f);

            // power ����
            power -= 0.1f;
        }

        // �߰������� yield return null;�� ����Ͽ� ��������� �ڷ�ƾ ����
        yield return null;
    }
    private IEnumerator KnockDown(float power)
    {
        // Rigidbody2D�� null���� Ȯ��
        if (rigid == null)
        {
            Debug.LogWarning("Rigidbody2D ������Ʈ�� ã�� �� �����ϴ�.");
            yield break; // �ڷ�ƾ ����
        }

        // �ʱ� �ӵ��� 0���� ����
        rigid.velocity = Vector2.zero;

        // power�� 0 �̻��� ���� �ݺ�
        while (power >= 0)
        {
            // Rigidbody�� �˹� ����� power�� ���� ���� �ӵ��� ����
            rigid.velocity = Vector2.down * power;

            // �ſ� ª�� �ð� ���� ���
            yield return new WaitForSeconds(0.0001f);

            // power ����
            power -= 0.1f;
        }

        // �߰������� yield return null;�� ����Ͽ� ��������� �ڷ�ƾ ����
        yield return null;
    }
}
