using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // 따라갈 플레이어의 Transform
    public Transform player;

    // 카메라와 플레이어 간의 오프셋 (카메라가 플레이어와 얼마나 떨어져 있을지)
    public Vector3 offset;

    // 카메라의 추적 속도 (부드럽게 따라오게 하는 정도)
    public float followSpeed = 0.1f;

    void Update()
    {
        // 카메라가 따라가야 할 목표 위치를 계산합니다.
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y, transform.position.z) + offset;
        
        // 카메라를 부드럽게 목표 위치로 이동시킵니다.
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed);
    }
}
