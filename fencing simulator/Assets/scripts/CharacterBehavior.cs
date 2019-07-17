using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehavior : MonoBehaviour
{
    private Animator character;

    public void Start()
    {
        character = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetButton("forward"))
        {
            character.SetFloat("advancing", 1f);
            character.SetFloat("retreating", 0f);
            character.SetFloat("torso cut", 0f);
            character.SetFloat("head cut", 0f);
        }
        else if (Input.GetButton("back"))
        {
            character.SetFloat("advancing", 0f);
            character.SetFloat("retreating", 1f);
            character.SetFloat("torso cut", 0f);
            character.SetFloat("head cut", 0f);
        }
        else if (Input.GetButton("torso cut"))
        {
            character.SetFloat("advancing", 0f);
            character.SetFloat("retreating", 0f);
            character.SetFloat("torso cut", 1f);
            character.SetFloat("head cut", 0f);
        }
        else if (Input.GetButton("head cut"))
        {
            character.SetFloat("advancing", 0f);
            character.SetFloat("retreating", 0f);
            character.SetFloat("torso cut", 0f);
            character.SetFloat("head cut", 1f);
        }
        else
        {
            character.SetFloat("advancing", 0f);
            character.SetFloat("retreating", 0f);
            character.SetFloat("torso cut", 0f);
            character.SetFloat("head cut", 0f);
        }
    }
}
