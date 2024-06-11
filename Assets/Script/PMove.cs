using UnityEngine;

public class PMove : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ� ����
    public float jumpForce = 10f; // ���� �� ����

    private float clickTime;
    public float minClickTime = 1;
    private bool isClick;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private bool isFloor;
    private bool justJump;
    private bool isLeft, isRight;

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

    public void ButtonDown()
    {
        isClick = true;
    }

    public void ButtonUp()
    {
        isClick = false;

        if(clickTime >= minClickTime)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            sr.flipX = false; // �������� �̵��� �� ��������Ʈ ������
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
        if(isLeft)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            sr.flipX = true; // �������� �̵��� �� ��������Ʈ ������
            isLeft = false;
        }
        if (isRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            sr.flipX = false; // �������� �̵��� �� ��������Ʈ ������
            isRight = false;
        }
        JumpCheck();
        Move();
    }
    //����

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
    public void Left()
    {

        isLeft = true;
    }
    public void Right()
    {
        isRight = true;
    }
    public void Jamp()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    //�̵�
    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            sr.flipX = true; // �������� �̵��� �� ��������Ʈ ������ 
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            sr.flipX = false; // �������� �̵��� �� ��������Ʈ ������
        }
    }
}

