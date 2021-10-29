    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator animator;
    SpriteRenderer characterRenderer;

    private void Awake()
    {
        //cache the animator component
        animator = GetComponent<Animator>();
        characterRenderer = GetComponent<SpriteRenderer>();
    }
    public void OnMove(float speed)
    {
        animator.SetFloat("Speed", Mathf.Abs(speed));
    }

    public void Flip(bool right) {
        if (right) {
            characterRenderer.flipX = false;
        } else {
            characterRenderer.flipX = true;
        }
    }

    public void OnJump() {
        animator.SetBool("IsJumping", true);
    }

    public void OnJumpEnd() {
        animator.SetBool("IsJumping", false);
    }

    public void OnHatFind() {
        animator.SetBool("IsWearingHat", true);
    }
}
