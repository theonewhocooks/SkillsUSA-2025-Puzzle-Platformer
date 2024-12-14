using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trinkets : MonoBehaviour
{
    private int hoards = 0;
    public GameObject MegaWarp;
    public Vector2 randomRangeMin = new Vector2(-10, -10);
    public Vector2 randomRangeMax = new Vector2(10, 10);


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hoards += 1;
            Vector3 randomPosition = new Vector3(
                 Random.Range(randomRangeMin.x, randomRangeMax.x),
                 Random.Range(randomRangeMin.y, randomRangeMax.y),
                 transform.position.z
            );
            transform.position = randomPosition;

            if (hoards == 1)
            {
                MegaWarp.SetActive(true);
            }
        }
    }


}
