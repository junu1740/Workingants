using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float maxSpeed;
    public float jumppower;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator anim;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //jump
        if (Input.GetButtonDown("Jump"))
            rigid.AddForce(Vector2.up * jumppower, ForceMode2D.Impulse);
        anim.SetBool("Jump", true);


        //������ȯ
        if (Input.GetButtonDown("Horizontal"))
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;

        //walk animation
        if (rigid.velocity.normalized.x == 0)
            anim.SetBool("Walk", false);
        else
            anim.SetBool("Walk", true);


        //stop
        if (Input.GetButtonUp("Horizontal"))
        {

            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed)//���� �ְ� �ӵ�
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);

        else if (rigid.velocity.x < maxSpeed * (-1))//���� �ְ� �ӵ�
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);





    }
}
