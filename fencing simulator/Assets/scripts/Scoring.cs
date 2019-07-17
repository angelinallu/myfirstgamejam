using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    private int opponent;
    private int player;
    private int point;
    private int rightOfWay;
    private int attacking;
    private int missed;
    private int parried;
    private int hit;

    private bool ongoing;

    // Start is called before the first frame update
    void Start()
    {
        point = 0;
        ongoing = true;
        rightOfWay = 0;
        attacking = 0;
        missed = 0;
        parried = 0;
        hit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        while (ongoing)
        {
            if (point == -1 && opponent < 15)
            {
                opponent++;
            }
            else if (point == 1 && player < 15)
            {
                player++;
            }
            ongoing &= opponent != 15 && player != 15;
        }
    }
}
