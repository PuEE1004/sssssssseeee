using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected NewBehaviourScript controller;
   
    protected  virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<NewBehaviourScript>();
    }
}
