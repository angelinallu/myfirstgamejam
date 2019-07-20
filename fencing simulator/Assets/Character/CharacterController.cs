using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public string playerID = "p1";

    private Animator characterAnimator;
    private int forwardHash;
    private int backHash;
    private int midActionHash;
    private int highActionHash;
    
    void Start()
    {
        characterAnimator = GetComponent<Animator>();
        midActionHash = Animator.StringToHash("MidAction");
        highActionHash = Animator.StringToHash("HighAction");
        forwardHash = Animator.StringToHash("ForwardPressed");
        backHash = Animator.StringToHash("BackPressed");
    }
    
    void Update()
    {
        characterAnimator.SetBool(forwardHash, Input.GetButton(playerID + "forward"));
        characterAnimator.SetBool(backHash, Input.GetButton(playerID + "back"));

        int animLayer = characterAnimator.GetLayerIndex("Base Layer");
        AnimatorStateInfo stateInfo = characterAnimator.GetCurrentAnimatorStateInfo(animLayer);
        if (stateInfo.IsName("Base Layer.Step_forward") || stateInfo.IsName("Base Layer.Step_backward"))
        {
            if (characterAnimator.GetBool(forwardHash))
            {
                transform.Translate(Vector3.forward * 0.75f * Time.deltaTime);
            }
            else if (characterAnimator.GetBool(backHash))
            {
                transform.Translate(Vector3.back * 0.75f * Time.deltaTime);
            }
        }

        if (!(stateInfo.IsName("Base Layer.Cut_head") || stateInfo.IsName("Base Layer.Cut_mid") || stateInfo.IsName("Base Layer.Duck_parry_5") || stateInfo.IsName("Base Layer.Jump_parry_2")))
        {
            if (Input.GetButtonDown(playerID + "midcut"))
            {
                characterAnimator.SetTrigger(midActionHash);
            }

            if (Input.GetButtonDown(playerID + "highcut"))
            {
                characterAnimator.SetTrigger(highActionHash);
            }
        }
    }
}
