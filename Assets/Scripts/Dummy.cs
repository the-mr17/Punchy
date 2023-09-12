using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    private Animator _animator;
    private bool _hasAnimator;
    private int _animIDHit;
    private int _animIDPunch;

    public bool isPunching;

    // Start is called before the first frame update
    void Start()
    {
        _hasAnimator = TryGetComponent(out _animator);
        _animIDHit = Animator.StringToHash("Hit");
        _animIDPunch = Animator.StringToHash("Punch");

        _animator.SetBool(_animIDPunch, isPunching);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.layer == 10 && ThirdPersonController.Instance.isBoxing) {
            _animator.SetBool(_animIDHit, true);
        }
    }

    private void OnCollisionExit(Collision other) {
        _animator.SetBool(_animIDHit, false);
    }
}
