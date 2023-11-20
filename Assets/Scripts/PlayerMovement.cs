using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rbody; 
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float jumpSpeed = 15f;

    private enum MoveState { idle, run, jump, fall };
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rbody.velocity = new Vector2(dirX * moveSpeed, rbody.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
        }
        switchAnimation();
    }

    private void switchAnimation()
    {
        MoveState state;

        if (dirX < 0f)
        {
            state = MoveState.run;
            spriteRenderer.flipX = true;
        }
        else if (dirX > 0f)
        {
            state = MoveState.run;
            spriteRenderer.flipX = false;
        }
        else
        {
            state = MoveState.idle;
        }

        if(rbody.velocity.y > .001f) 
        {
            state = MoveState.jump;
        }else if (rbody.velocity.y < -.001f) {
            state = MoveState.fall;
        }

        animator.SetInteger("state", (int)state);
    }
}