using System;
using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private static readonly int Slide = Animator.StringToHash("slide");
    private static readonly int Attack = Animator.StringToHash("attack");
    private static readonly int jump = Animator.StringToHash("jump");

    private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnAttackEvent += Attacking;
        controller.OnMoveEvent += Move;
        controller.OnSlideEvent += Sliding;
        controller.OnJumpEvent += Jumping;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }

    private void Attacking(Vector2 vector)
    {
        animator.SetTrigger(Attack);
    }

    private void Sliding(Vector2 vector)
    {
        animator.SetTrigger(Slide);
    }

    private void Jumping(Vector2 vector)
    {
        animator.SetTrigger(jump);
    }
}
