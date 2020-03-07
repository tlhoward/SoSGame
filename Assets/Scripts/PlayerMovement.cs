using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public float moveSpeed = 5f;
    
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    void Start() 
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() 
    {
        movement = Vector2.zero;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;
        UpdateAnimationAndMovement();
    }

    void UpdateAnimationAndMovement()
    {
        if (movement != Vector2.zero) 
        {
            MoveCharacter();
            animator.SetFloat("moveX", movement.x);
            animator.SetFloat("moveY", movement.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    void MoveCharacter() 
    {
        // Movement
        rb.MovePosition((Vector2)transform.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
