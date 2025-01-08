using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowdown : MonoBehaviour
{
    public PlayerController playerController;
    public PlayerController2 playerController2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            playerController.GetComponent<PlayerController>().JumpForce = 8;
        }

        if (other.gameObject.CompareTag("Player2"))
        {
            playerController2.GetComponent<PlayerController2>().JumpForce = 8;
        }
    }

}
