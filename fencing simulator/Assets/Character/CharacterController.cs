using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator characterAnimator;
    private int movementHash;
    private int forwardHash;
    private int backHash;
    private int midActionHash;
    private int highActionHash;
    
    void Start()
    {
        characterAnimator = GetComponent<Animator>();
        movementHash = Animator.StringToHash("Movement");
        midActionHash = Animator.StringToHash("MidAction");
        highActionHash = Animator.StringToHash("HighAction");
        forwardHash = Animator.StringToHash("ForwardPressed");
        backHash = Animator.StringToHash("BackPressed");
    }
    
    void Update()
    {
        characterAnimator.SetFloat(movementHash, Input.GetAxis("Vertical"));

        characterAnimator.SetBool(forwardHash, Input.GetButton("forward"));
        characterAnimator.SetBool(backHash, Input.GetButton("back"));

        if (Input.GetButtonDown("torso cut"))
        {
            characterAnimator.SetTrigger(midActionHash);
        }

        if (Input.GetButtonDown("head cut"))
        {
            characterAnimator.SetTrigger(highActionHash);
        }
    }
}
