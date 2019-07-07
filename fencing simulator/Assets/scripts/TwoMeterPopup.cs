using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TwoMeterPopup : MonoBehaviour
{
    private Text textComponent;

    public TwoMeterTrigger trigger;

    public void Start()
    {
        textComponent = GetComponent<Text>();
        trigger.WarningEvent += Popup;
    }

    public void Popup(bool warningState)
    {
        textComponent.enabled = warningState;
    }

}
