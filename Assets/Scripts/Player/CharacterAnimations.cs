using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterAnimations : MonoBehaviour, IAnimated
{
    private Animator animator;

    private void Awake()
    {
        animator= GetComponent<Animator>();
    }

    public void SetDirectionForCharacter(float x, float y)
    {
        animator.SetFloat("moveX", x);
        animator.SetFloat("moveY", y);
    }
}