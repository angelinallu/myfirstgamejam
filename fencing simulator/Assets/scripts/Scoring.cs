using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Scoring : MonoBehaviour
{
    private int playerScore = 0;
    private TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        text = GetComponent<TextMeshProUGUI>();
        text.text = playerScore.ToString();
    }

    public void AddPoint()
    {
        playerScore++;
        text.text = playerScore.ToString();
        if (playerScore >= 15)
        {
            //You win!
            SceneManager.LoadScene("menu");
        }
    }
}
