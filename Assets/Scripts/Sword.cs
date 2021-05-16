using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (heldState != HeldState.Dropped
            && GameplayStatics.Instance.IsAnimationPlaying(charAnimator, "Attack"))
        {
            Vector3 dir = owner.GetFacingDir();

            if (heldState == HeldState.Player)
            {
                if (collision.TryGetComponent(out Enemy enemy))
                {
                    enemy.TakeDamage(damage, dir, force);
                }
            }
            else if (heldState == HeldState.Enemy)
            {
                if (collision.TryGetComponent(out Player player))
                {
                    player.TakeDamage(damage, dir, force);
                }
            }
        }
    }
}
