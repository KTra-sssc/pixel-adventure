using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private Animator m_Animator;
    private Rigidbody2D m_Rigidbody;
    private void Start()
    {
        m_Animator = GetComponent<Animator>(); 
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            Death();
        }
    }

    private void Death()
    {
        m_Animator.SetTrigger("death");
        m_Rigidbody.bodyType = RigidbodyType2D.Static;
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
