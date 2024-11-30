using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public BoxCollider2D collider;
    public Animator animator;

    public bool platePressed1;
    public bool platePressed2;
    
    public void Open()
    {
        collider.enabled = false;
        animator.SetBool("isOpened", true);
    }

    public void Close()
    {
        animator.SetBool("isOpened", false);
        collider.enabled = true;

    }
}
