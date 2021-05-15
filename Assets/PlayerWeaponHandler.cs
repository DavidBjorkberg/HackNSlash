using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponHandler : MonoBehaviour
{
    [SerializeField] private Weapon startWeapon;
    [SerializeField] private Transform weaponSocket;
    [SerializeField] private Animator animator;
    private Weapon currentWeapon;

    private void Awake()
    {
        currentWeapon = Instantiate(startWeapon, weaponSocket);
        currentWeapon.heldState = Weapon.HeldState.Player;
        currentWeapon.Equip(animator, GetComponent<Character>());
    }
}
