﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSettings : MonoBehaviour
{
    public void Settings()
    {
        SceneManager.LoadScene("settings");
    }
}