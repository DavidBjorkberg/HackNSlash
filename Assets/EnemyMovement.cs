using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
     private Animator animator;
    [SerializeField] private float movementSpeed;
    [SerializeField] private LayerMask levelLayer;
    [SerializeField] private float groundedCheckLength;
    private Player player;
    private Rigidbody2D rb;

    private void Awake()
    {
        animator = GetComponent<Enemy>().GetAnimator();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameplayStatics.Instance.GetPlayer();
        animator.SetBool("isWalking", true);
    }

    void Update()
    {
        SetAnimationParameters();
        Walk();
    }
    void Walk()
    {

        if (!GameplayStatics.Instance.IsAnimationPlaying(animator, "Attack"))
        {
            float playerX = player.transform.position.x;
            if (playerX > transform.position.x)
            {
                transform.position += Vector3.right * movementSpeed * Time.deltaTime;
                GameplayStatics.Instance.FlipSprite(transform, true);
            }
            else
            {
                transform.position += Vector3.left * movementSpeed * Time.deltaTime;
                GameplayStatics.Instance.FlipSprite(transform, false);
            }

        }
    }
    void SetAnimationParameters()
    {
        animator.SetBool("isGrounded", IsGrounded());
        animator.SetFloat("velocityY", rb.velocity.y);
    }
    bool IsGrounded()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, groundedCheckLength, levelLayer);
    }
}
