using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAnimation : MonoBehaviour
{
    public Animator animator;

    private void Update()
    {
        CheckAnimations();
    }

    void CheckAnimations()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("isIdle", false);
            animator.SetTrigger("isParrying");
        }
    }

    void OnAnimationComplete()
    {
        animator.SetBool("isIdle", true);
    }
}
