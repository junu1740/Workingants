using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // ����ٴ� ���(�÷��̾� ��)�� Transform
    public Transform background; // ��� ������Ʈ�� Transform

    public float smoothSpeed = 0.125f; // ī�޶� �̵� �ӵ�
    public Vector3 offset; // ī�޶�� ��� ������ ������

    void FixedUpdate()
    {
        if (target != null)
        {
            // ����� ��ġ�� ī�޶� �̵�
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
        }

        // ����� ����ٴϵ��� ����
        if (background != null)
        {
            background.position = new Vector3(transform.position.x, transform.position.y, background.position.z);
        }
    }

}
