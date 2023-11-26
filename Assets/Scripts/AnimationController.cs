using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    void Start()
    {
         _animator = GetComponent<Animator>();
    }

    public void Idle()
    {
        _animator.SetFloat("Blend", 0);
    }

    public void Walk()
    {
        _animator.SetFloat("Blend", 0.5f); 
    }

    public void Run()
    {
           _animator.SetFloat("Blend", 1);
    }   
}
