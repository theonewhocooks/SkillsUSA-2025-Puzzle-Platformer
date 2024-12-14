using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadScript : MonoBehaviour
{
    public Vector2 randomRangeMin = new Vector2(-10, -10);
    public Vector2 randomRangeMax = new Vector2(10, 10);

    void Start()
    {
        // Move this object to a random position upon initialization
        Vector3 randomPosition = new Vector3(
            Random.Range(randomRangeMin.x, randomRangeMax.x),
            transform.position.y,
            transform.position.z
        );
        transform.position = randomPosition;
        Debug.Log(randomPosition);
    }
}