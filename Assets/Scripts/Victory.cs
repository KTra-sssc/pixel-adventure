using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    private AudioSource victorySFX;
    private bool m_Finished = false;
    void Start()
    {
        victorySFX = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !m_Finished)
        {
            victorySFX.Play();
            m_Finished = true;
            Invoke("Finish", 2f);
        }
    }

    private void Finish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
