using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button button;
    public string destination;

    public void Clicked()
    {
        SceneManager.LoadScene(destination);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Resume()
    {
        //resume
    }
}