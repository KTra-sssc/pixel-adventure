using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rbody; 
    private Animator animator;
    private float dirX = 0f;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rbody.velocity = new Vector2(dirX * 7f, rbody.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rbody.velocity = new Vector2(rbody.velocity.x, 15);
        }
        switchAnimation();
    }

    void switchAnimation()
    {
        if (dirX < 0f)
        {
            animator.SetBool("run", true);
            spriteRenderer.flipX = true;
        }
        else if (dirX > 0f)
        {
            animator.SetBool ("run", true);
            spriteRenderer.flipX = false;
        }
        else
        {
            animator.SetBool("run", false);
        }
    }
}