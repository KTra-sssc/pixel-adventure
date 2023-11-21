using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour
{
    private int item = 0;
    [SerializeField] private Text score;
    [SerializeField] private AudioSource collectSFX;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("item"))
        {
            Destroy(collision.gameObject);
            item++;
            score.text = "Score: " + item;
            collectSFX.Play();
        }
    }
}
