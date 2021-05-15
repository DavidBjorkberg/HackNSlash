using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public abstract void TakeDamage(int amount, Vector3 dir, float force);
    public virtual Vector3 GetFacingDir()
    {
        if(transform.localScale == Vector3.one)
        {
            return Vector3.left;
        }
        else
        {
            return Vector3.right;
        }
    }
}
