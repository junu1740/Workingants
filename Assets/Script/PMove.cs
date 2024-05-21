using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{

    public float moveSpeed = 5f; // 이동 속도 조절
    public float jumpForce = 10f; // 점프 힘 조절

    private Rigidbody2D rb;
   
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        // 'a' 키를 누르면 왼쪽으로 이동
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        // 'd' 키를 누르면 오른쪽으로 이동
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

