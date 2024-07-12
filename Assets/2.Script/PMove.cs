
using UnityEngine;

public class PMove : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도 조절
    public GameObject ESC_UI;
    public GameObject MiniCam;
    public GameObject AntArrow;

    private AudioSource audioSource;


    public AudioClip JumpClip;
    private float clickTime;
    private float E = 0;
    public float minClickTime = 1;
    private bool isClick;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private bool controlsReversed = false;

    private bool isFloor;
    private bool justJump;
    private bool isLeft, isRight;
    private bool isreverse;

    public static PMove instance;


    public float jumpForce = 10f;
    public int maxJumpCount = 2;  // 최대 점프 횟수

    public int jumpCount = 0;    // 현재 점프 횟수

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();

    }

    private void Awake()
    {
        instance = this;
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
            AntArrow.SetActive(!AntArrow.activeSelf);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < maxJumpCount)
            {
                Jump();
            }
        }
        if (isLeft)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            transform.localScale = new Vector2(-4.07671f, transform.localScale.y);
            sr.flipX = true; // 좌측으로 이동할 때 스프라이트 뒤집기
            isLeft = false;
        }
        if (isRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            transform.localScale = new Vector2(4.07671f, transform.localScale.y);
            sr.flipX = false; // 우측으로 이동할 때 스프라이트 뒤집기
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

    // 점프 횟수 초기화
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


    //이동
    private void Move()
    {


        float horizontalInput = Input.GetAxis("Horizontal");
        Invoke("MirrorTimer", 5);

        if (isreverse == true)
        {
            Vector3 moveDirection = new Vector3(horizontalInput, 0f, 0f);
            if (horizontalInput < 0f)
            {
                transform.localScale = new Vector3(4.07671f, transform.localScale.y, transform.localScale.z);
            }
            else if (horizontalInput > 0f)
            {
                transform.localScale = new Vector3(-4.07671f, transform.localScale.y, transform.localScale.z);
            }
            transform.Translate(moveDirection * -moveSpeed * Time.deltaTime);
        }
        else
        {
            Vector3 moveDirection = new Vector3(horizontalInput, 0f, 0f);
            if (horizontalInput < 0f)
            {
                transform.localScale = new Vector3(-4.07671f, transform.localScale.y, transform.localScale.z);
            }
            else if (horizontalInput > 0f)
            {
                transform.localScale = new Vector3(4.07671f, transform.localScale.y, transform.localScale.z);
            }
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
    }

    void MirrorTimer()
    {
        isreverse = false;
    }
    public void MirrorCheck()
    {
        isreverse = true;
    }
}

