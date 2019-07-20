using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBlade : MonoBehaviour
{
    public Animator playerAnimator;

    private int parryHash = Animator.StringToHash("Parry");

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sword Blade")
        {
            Debug.Log("clang!");
            playerAnimator.SetTrigger(parryHash);
        }
    }
}
