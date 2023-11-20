using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rbody; 
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpSpeed = 15f;
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
        rbody.velocity = new Vector2(dirX * moveSpeed, rbody.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
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