using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private EnemyWeaponHandler weaponHandler;
    private Animator animator;
    private void Start()
    {
        weaponHandler = GetComponent<EnemyWeaponHandler>();
        animator = GetComponent<Enemy>().GetAnimator();
    }
    private void Update()
    {
        if (ShouldAttack())
        {
            Attack();
        }
    }
    void Attack()
    {
        animator.SetTrigger("attacked");
    }
    protected virtual bool ShouldAttack()
    {
        Vector3 playerPos = GameplayStatics.Instance.GetPlayer().transform.position;
        float distToPlayer = (playerPos - transform.position).magnitude;
        return distToPlayer <= weaponHandler.GetCurrentWeapon().GetRange();
    }
}
