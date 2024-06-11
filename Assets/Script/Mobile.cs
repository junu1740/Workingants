using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도 조절
    public float jumpForce = 10f; // 점프 힘 조절
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public void Left()
    {

        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        sr.flipX = true; // 좌측으로 이동할 때 스프라이트 뒤집기
    }
    public void Right()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        sr.flipX = false; // 우측으로 이동할 때 스프라이트 뒤집기
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
