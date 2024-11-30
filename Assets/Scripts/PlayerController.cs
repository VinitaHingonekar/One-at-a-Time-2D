using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public BoxCollider2D collider;
    private Vector2 movement;

    public Animator animator;

    public Transform feetTransform;

    public enum PlayerType
    {
        FAST,
        STRONG
    }

    public PlayerType playerType;

    public bool isActive;
    private bool canMove = true;

    void Update()
    {
        // HandleInput();
        IsTouchingWater();
        if(isActive)
        {
            HandleInput();
        }
    }

    private void FixedUpdate() 
    {
        // rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        if(canMove)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            
        }
    }

    private void UpdateAnimationParameters(float moveX, float moveY)
    {
        animator.SetFloat("MoveX", moveX);
        animator.SetFloat("MoveY", moveY);
    }


    private void HandleInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        movement = new Vector2(moveX, moveY).normalized;
        UpdateAnimationParameters(moveX, moveY);
    }

    private void IsTouchingWater()
    {
        Vector2 moveDirection = movement.normalized;
        float rayDistance = 0.8f;

        RaycastHit2D hit = Physics2D.Raycast(feetTransform.position, moveDirection, rayDistance, LayerMask.GetMask("Water"));
        Debug.DrawRay(feetTransform.position, moveDirection * rayDistance, Color.red);


        if (hit.collider != null)
        {
            canMove = false;
            // Debug.Log("Water detected in movement direction");
        }
        else
        {
            canMove = true;
        }
    }

}
