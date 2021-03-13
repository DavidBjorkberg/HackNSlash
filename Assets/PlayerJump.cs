using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private KeyCode jumpButton;
    [SerializeField] private LayerMask levelLayer;
    [SerializeField] private float groundedCheckLength;
    private Rigidbody2D rb;
    private Animator animator; 
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(jumpButton) && IsGrounded())
        {
            rb.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
        }
        animator.SetBool("isGrounded", IsGrounded());
        animator.SetFloat("velocityY", rb.velocity.y);
    }
    bool IsGrounded()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, groundedCheckLength, levelLayer);
    }
}
