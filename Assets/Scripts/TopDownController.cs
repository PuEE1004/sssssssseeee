using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action<Vector2> OnAttackEvent;
    public event Action<Vector2> OnSlideEvent;
    public event Action<Vector2> OnJumpEvent;


    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    public void CallAttackEvent(Vector2 direction)
    {
        OnAttackEvent?.Invoke(direction);
    }

    public void CallSlideEvent(Vector2 direction)
    {
        OnSlideEvent?.Invoke(direction);
    }

    public void CallJumpEvent(Vector2 direction)
    {
        OnJumpEvent?.Invoke(direction);
    }
}
