using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level2";
    [SerializeField] private string restartGameLevel = "david dev";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void RestartGameButton()
    {
        SceneManager.LoadScene(restartGameLevel);
    }
}
