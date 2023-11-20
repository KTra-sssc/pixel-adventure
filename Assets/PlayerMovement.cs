using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rbody; 
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rbody.velocity = new Vector2(dirX * 7f, rbody.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rbody.velocity = new Vector2(rbody.velocity.x, 15);
        }
    }
}