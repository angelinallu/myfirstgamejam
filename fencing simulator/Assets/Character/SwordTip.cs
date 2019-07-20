using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordTip : MonoBehaviour
{
    public Scoring scoreKeeper;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target Area")
        {
            scoreKeeper.AddPoint();
        }
    }
}
