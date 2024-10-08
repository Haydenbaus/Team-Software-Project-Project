using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public Button quitButton;
    public Button startButton;

    void Start()
    {
        // Assign functionality to menu
        startButton.onClick.AddListener(GameStart);
        quitButton.onClick.AddListener(QuitGame);

    }

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
