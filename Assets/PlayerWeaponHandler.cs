using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponHandler : MonoBehaviour
{
    [SerializeField] private Weapon startWeapon;
    [SerializeField] private Transform weaponSocket;
    private Animator animator;
    private Weapon currentWeapon;

    private void Awake()
    {
        animator = GetComponent<Player>().GetAnimator();

        currentWeapon = Instantiate(startWeapon, weaponSocket);
        currentWeapon.heldState = Weapon.HeldState.Player;
        currentWeapon.Equip(animator, GetComponent<Character>());
    }
}
