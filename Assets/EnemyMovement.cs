using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private float movementSpeed;
    private Player player;

    void Start()
    {
        player = GameplayStatics.Instance.GetPlayer();
        animator.SetBool("isWalking", true);
    }

    void Update()
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
