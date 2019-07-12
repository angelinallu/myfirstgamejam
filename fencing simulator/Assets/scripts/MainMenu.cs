using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("play modes");
    }
    public void HighScores()
    {
        SceneManager.LoadScene("high scores");
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
    public void Settings()
    {
        SceneManager.LoadScene("settings");
    }
    public void Credits()
    {
        SceneManager.LoadScene("credits");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
