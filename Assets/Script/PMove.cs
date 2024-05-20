using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{

    public float speed = 5f; // 이동 속도 조절
    public float jumpForce = 10f; // 점프 힘 조절

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
        // 플레이어 이동
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        // 바닥과 충돌하는지 확인
        isGrounded = Physics2D.OverlapBox(groundCheck.position, new Vector2(groundCheckWidth, groundCheckHeight), 0, groundLayer);

        // 플레이어 점프
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void OnDrawGizmosSelected()
    {
        // Gizmos를 통해 groundCheck 위치와 크기를 시각적으로 나타냄
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(groundCheck.position, new Vector3(groundCheckWidth, groundCheckHeight, 0));
    }

}

