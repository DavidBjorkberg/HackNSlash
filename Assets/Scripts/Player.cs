using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public override void TakeDamage(int amount, Vector3 dir, float force)
    {
        dir.Normalize();

        Vector3 bisection = (dir + Vector3.up).normalized;
        rb.AddForce(bisection * force, ForceMode2D.Impulse);
        print("Player took " + amount + " damage");
    }
}
