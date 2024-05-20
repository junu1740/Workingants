using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // 따라다닐 대상(플레이어 등)의 Transform
    public Transform background; // 배경 오브젝트의 Transform

    public float smoothSpeed = 0.125f; // 카메라 이동 속도
    public Vector3 offset; // 카메라와 대상 사이의 오프셋

    void FixedUpdate()
    {
        if (target != null)
        {
            // 대상의 위치에 카메라를 이동
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
        }

        // 배경을 따라다니도록 설정
        if (background != null)
        {
            background.position = new Vector3(transform.position.x, transform.position.y, background.position.z);
        }
    }

}
