using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject losePanel;
    public void ShowWinPanel()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0;

    }

    public void ShowLosePanel()
    {
        losePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void NextLevel()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex <= 1)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
