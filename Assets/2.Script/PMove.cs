 using UnityEngine;

public class PMove : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ� ����
    public GameObject ESC_UI;
    public GameObject MiniCam;

    private AudioSource audioSource;

   
    public AudioClip JumpClip;
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

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
      
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ESC_UI.SetActive(!ESC_UI.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            MiniCam.SetActive(!MiniCam.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < maxJumpCount)
            {
                Jump();
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
                jumpCount++;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        audioSource.PlayOneShot(JumpClip);
        
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
   


    
    //����

    
   
    public void Left()
    {

        isLeft = true;
    }
    public void Right()
    {
        isRight = true;
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

