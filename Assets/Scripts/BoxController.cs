using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed = 5f;

    private bool isMoving;
    private Vector2 moveDirection;
    private Vector2 movement;

    private bool isOnGround = true;

    private Vector2 startingPosition;

    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = transform.position;
    }

    void Update()
    {
        CheckIfOnGround();
    }

    private void CheckIfOnGround()
    {
        float rayDistance = 0.6f;
        Vector2 moveDirection = rb.velocity.normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, moveDirection, rayDistance, LayerMask.GetMask("Water"));
        Debug.DrawRay(transform.position, moveDirection * rayDistance, Color.red);

        if (hit.collider != null)
        {
            StartCoroutine("Respawn");
        }

    }

    private IEnumerator Respawn()
    {
        animator.SetBool("BoxRespawn", true);
        yield return new WaitForSeconds(0.3f);
        transform.position = startingPosition;
        animator.SetBool("BoxRespawn", false);
        // yield return new WaitForSeconds(0.3f);
    }

}
