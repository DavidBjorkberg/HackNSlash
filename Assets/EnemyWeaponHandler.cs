using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponHandler : MonoBehaviour
{
    [SerializeField] private Weapon startWeapon;
    [SerializeField] private Transform weaponSocket;
    private Weapon currentWeapon;
    private Animator animator;
    
    private void Awake()
    {
        animator = GetComponent<Enemy>().GetAnimator();

        currentWeapon = Instantiate(startWeapon, weaponSocket);
        currentWeapon.heldState = Weapon.HeldState.Enemy;
        currentWeapon.Equip(animator, GetComponent<Character>());
    }
    public Weapon GetCurrentWeapon()
    {
        return currentWeapon;
    }
}
