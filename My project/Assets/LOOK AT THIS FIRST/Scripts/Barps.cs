using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barps : MonoBehaviour
{
    public Vector3 targetPosition;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player2"))
        {
            other.gameObject.transform.position = targetPosition;
        }
    }
}