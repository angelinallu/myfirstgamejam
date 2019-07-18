//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class animation : MonoBehaviour
//{
//    private Animator animator;

//    public void Start()
//    {
//        animator = GetComponent<Animator>();
//    }
//    private void Update()
//    {
//        if (Input.GetButton("forward"))
//        {
//            animator.SetBool("move forward", true);
//            animator.SetBool("move back", false);
//            animator.SetBool("reset", false);
//        }
//        else if (Input.GetButton("back"))
//        {
//            animator.SetBool("move forward", false);
//            animator.SetBool("move back", true);
//            animator.SetBool("reset", false);
//        }
//        else
//        {
//            animator.SetBool("move forward", false);
//            animator.SetBool("move back", false);
//            animator.SetBool("reset", true);
//        }

//    }
//}
