using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{

    public AudioMixer mixer;
    public Slider slider;

    void Start()
    {
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
        }
        else
        {
            PlayerPrefs.SetFloat("MusicVolume", slider.value);
        }
    }
    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("Volume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }
}