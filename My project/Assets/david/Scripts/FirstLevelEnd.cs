using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLevelEnd : MonoBehaviour
{
    public Vector3 targetPosition;
    public GameObject otherPlayer;
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           otherPlayer.transform.position = targetPosition;
        }
    }

}
