using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level2";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
