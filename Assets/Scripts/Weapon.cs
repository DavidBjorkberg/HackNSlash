using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    internal enum HeldState { Player, Enemy, Dropped };
    internal HeldState heldState;
    [SerializeField] private AnimationClip attackAnimClip;
    [SerializeField] protected int damage;
    [SerializeField] protected float force;
    [SerializeField] private float range;
    protected Animator charAnimator;
    protected Character owner;
    private AnimatorOverrideController animatorOverrideController;
    public virtual void Attack(Vector3 pos, Vector3 dir) { }

    public virtual void Equip(Animator animator, Character character)
    {
        animatorOverrideController = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = animatorOverrideController;
        animatorOverrideController["DefaultAttackAnim"] = attackAnimClip;

        charAnimator = animator;
        owner = character;
    }
}
