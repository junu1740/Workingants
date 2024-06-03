using UnityEngine;

public class PMove : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도 조절
    public float jumpForce = 10f; // 점프 힘 조절

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private bool isFloor;
    private bool justJump;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = false;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Jump();
    }
    void Update()
    {
        JumpCheck();
        Move();
    }
    //점프

    void JumpCheck()
    {
        if (isFloor)
        {
        if (isFloor && Input.GetKeyDown(KeyCode.Space))
           {
                justJump = true;    
           }

        }
    }
    private void Jump()
    {
        if (justJump)
        {
            justJump = false;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        }
    }

    //이동
    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            sr.flipX = true; // 좌측으로 이동할 때 스프라이트 뒤집기
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            sr.flipX = false; // 우측으로 이동할 때 스프라이트 뒤집기
        }
    }
}

