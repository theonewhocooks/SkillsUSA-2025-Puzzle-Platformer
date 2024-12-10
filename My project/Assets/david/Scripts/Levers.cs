using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Levers : MonoBehaviour
{
    public TMP_InputField charHolder;
    public GameObject Lever1;
    public GameObject Lever2;
    public GameObject Lever3;
    public GameObject Lever4;
    public GameObject Lever5;
    public GameObject Lever6;


    void OnColliderEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            Debug.Log("putttttt it innnn my asssssss");

        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            charHolder.text = charHolder.text + "2";
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            charHolder.text = charHolder.text + "3";
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            charHolder.text = charHolder.text + "4";
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            charHolder.text = charHolder.text + "5";
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            charHolder.text = charHolder.text + "6";
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            charHolder.text = null;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (charHolder.text == "42")
            {
                Debug.Log("yarito");
            }
            else
            {
                Debug.Log("don larma");
            }

            charHolder.text = null;
        }
    }
}