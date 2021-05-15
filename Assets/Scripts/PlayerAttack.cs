using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private KeyCode attackButton;
    [SerializeField] private Animator animator;

    private void Update()
    {
        if (Input.GetKeyDown(attackButton))
        {
            animator.SetTrigger("attacked");
        }
    }
}
