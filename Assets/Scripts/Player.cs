using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public override void TakeDamage(int amount, Vector3 dir, float force)
    {
        print("Player took " + amount + " damage");
    }
}
