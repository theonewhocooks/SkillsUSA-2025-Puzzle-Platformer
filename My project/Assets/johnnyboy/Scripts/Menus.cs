using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public int levelOne;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene(levelOne);
    }
}
