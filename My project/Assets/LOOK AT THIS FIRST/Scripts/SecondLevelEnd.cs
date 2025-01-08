using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLevelEnd : MonoBehaviour
{
    public GameObject secondPlayer;
    public GameObject firstPlayer;
    public Vector3 targetPosition1;
    public Vector3 targetPosition2;
    public GameObject winText1;
    public GameObject winText2;
    public GameObject button;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
           secondPlayer.transform.position = targetPosition2;
           winText1.SetActive(true);
           button.SetActive(true);
        }

        if (other.gameObject.CompareTag("Player2"))
        {
           firstPlayer.transform.position = targetPosition1;
           winText2.SetActive(true);
           button.SetActive(true);
        }
    }

}
