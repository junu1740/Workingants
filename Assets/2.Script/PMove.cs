 using UnityEngine;

public class PMove : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ� ����
    public GameObject ESC_UI;
   

    private float clickTime;
    private float E = 0;
    public float minClickTime = 1;
    private bool isClick;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private bool isFloor;
    private bool justJump;
    private bool isLeft, isRight;

    public static PMove instance;


    public float jumpForce = 10f;
    public int maxJumpCount = 2;  // �ִ� ���� Ƚ��

    public int jumpCount = 0;    // ���� ���� Ƚ��

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            E++;
            if(E == 1)
            {
            ESC_UI.SetActive(true);
                Debug.Log("1");
                E = 0;
                Debug.Log("0");
            }
            else
            {
                ESC_UI.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < maxJumpCount)
            {
                Jump();
                jumpCount++;
            }
        }
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

        Move();
    }

    void Jump()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
    }

    // ���� Ƚ�� �ʱ�ȭ
    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
        }
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
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

    
    //����

    
   
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
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            sr.flipX = true; // �������� �̵��� �� ��������Ʈ ������ 
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            sr.flipX = false; // �������� �̵��� �� ��������Ʈ ������
        }


    }
}

