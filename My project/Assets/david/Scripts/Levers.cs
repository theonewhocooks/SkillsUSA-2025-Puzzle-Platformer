using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Levers : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            Debug.Log("putttttt it innnn my asssssss");

        }
    }

}