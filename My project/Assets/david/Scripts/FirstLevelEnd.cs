using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstLevelEnd : MonoBehaviour
{
    public GameObject winText;
    public Vector3 targetPosition;
    public GameObject otherPlayer;
    public GameObject winText2;
    public Vector3 targetPosition2;
    public GameObject otherPlayer2;
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
           otherPlayer.transform.position = targetPosition;
           winText.SetActive(true);
        }

        if (other.gameObject.CompareTag("Player2"))
        {
           otherPlayer2.transform.position = targetPosition2;
           winText2.SetActive(true);
        }
    }

}
