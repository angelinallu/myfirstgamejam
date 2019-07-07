using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 10;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0f, 0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    //void Edge()
    //{
    //    Debug.Log('end');
    //}

}
