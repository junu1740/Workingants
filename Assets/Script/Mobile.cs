using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ� ����
    public float jumpForce = 10f; // ���� �� ����
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public void Left()
    {

        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        sr.flipX = true; // �������� �̵��� �� ��������Ʈ ������
    }
    public void Right()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        sr.flipX = false; // �������� �̵��� �� ��������Ʈ ������
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
