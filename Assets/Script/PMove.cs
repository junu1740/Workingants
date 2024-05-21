using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{

    public float moveSpeed = 5f; // �̵� �ӵ� ����
    public float jumpForce = 10f; // ���� �� ����

    private Rigidbody2D rb;
   
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        // 'a' Ű�� ������ �������� �̵�
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        // 'd' Ű�� ������ ���������� �̵�
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}

