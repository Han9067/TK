using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpd = 2f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public KeyCode keyTest = KeyCode.A;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Rigidbody2D를 이용한 이동 처리
        rb.MovePosition(rb.position + movement * moveSpd * Time.fixedDeltaTime);
        
    }
}
