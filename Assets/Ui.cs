using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour
{

[SerializeField] private GameObject _deadDisplay;
[SerializeField] private GameObject _winDisplay;
[SerializeField] private GameObject _pauseDisplay;

    public void DeadDisplay () => StartDisplay(_deadDisplay);

    public void WinDisplay () => StartDisplay(_winDisplay);

    public void PauseDisplay () => StartDisplay(_pauseDisplay);

    private void StartDisplay (params GameObject[] display)
    {
        for (int i = 0; i < display.Length; i++)
        {
            display[i].SetActive(true);
        }
    }

    public void NextLevel ()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene++);
    }

    public void Restart ()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void Menu ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Continue ()
    {
        _pauseDisplay.SetActive(false);
    }
}
