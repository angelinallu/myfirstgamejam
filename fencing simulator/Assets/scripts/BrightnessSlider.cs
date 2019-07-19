using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessSlider : MonoBehaviour
{
    private float rbgValue = 0.5f;
    public Slider slider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Brightness"))
        {
            slider.value = PlayerPrefs.GetFloat("Brightness", 0.5f);
        }
        else
        {
            PlayerPrefs.SetFloat("Brightness", 0.5f);
        }
    }
    public void Slide()
    {
        RenderSettings.ambientLight = new Color(slider.value, slider.value, slider.value, 1);
        PlayerPrefs.SetFloat("Brightness", slider.value);
    }
}
