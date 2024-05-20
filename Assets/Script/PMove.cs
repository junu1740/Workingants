using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{

    public float speed = 5f; // �̵� �ӵ� ����
    public float jumpForce = 10f; // ���� �� ����

    private Rigidbody2D rb;
    private bool isGrounded = false;
    public Transform groundCheck;
    public float groundCheckWidth = 0.2f;
    public float groundCheckHeight = 0.1f;
    public LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // �÷��̾� �̵�
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        // �ٴڰ� �浹�ϴ��� Ȯ��
        isGrounded = Physics2D.OverlapBox(groundCheck.position, new Vector2(groundCheckWidth, groundCheckHeight), 0, groundLayer);

        // �÷��̾� ����
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void OnDrawGizmosSelected()
    {
        // Gizmos�� ���� groundCheck ��ġ�� ũ�⸦ �ð������� ��Ÿ��
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(groundCheck.position, new Vector3(groundCheckWidth, groundCheckHeight, 0));
    }

}

