using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoMeterTrigger : MonoBehaviour
{
    public delegate void WarningDelegate(bool danger);

    public event WarningDelegate WarningEvent;

    private void OnTriggerEnter(Collider other)
    {
        WarningEvent(true);
    }

    private void OnTriggerExit(Collider other)
    {
        WarningEvent(false);
    }
}
