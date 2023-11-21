using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    private AudioSource victorySFX;
    void Start()
    {
        victorySFX = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            victorySFX.Play();
            Finish();
        }
    }

    private void Finish()
    {
      
    }
}
