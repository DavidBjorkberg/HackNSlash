using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private Rigidbody2D rb;

    public override void TakeDamage(int amount, Vector3 dir, float force)
    {
        dir.Normalize();
        Vector3 bisection = (dir + Vector3.up).normalized;
        rb.AddForce(bisection * force,ForceMode2D.Impulse);
        print("Enemy took " + amount + "damage");
        }
    }
