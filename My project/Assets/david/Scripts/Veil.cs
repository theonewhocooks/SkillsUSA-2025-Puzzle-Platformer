using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veil : MonoBehaviour
{
    public GameObject _key;
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
            _key.SetActive(true);
            StartCoroutine(Hide());
        }
    }

    private IEnumerator Hide()
    {
        yield return new WaitForSeconds(10);
        _key.SetActive(false);
    }

}
