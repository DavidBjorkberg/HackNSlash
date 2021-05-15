using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private Animator animator;
    void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");

        if (horizontalMovement != 0)
        {
            transform.position += Vector3.right * horizontalMovement * movementSpeed * Time.deltaTime;
            GameplayStatics.Instance.FlipSprite(transform, horizontalMovement > 0);
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }

}
