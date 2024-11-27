using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public BoxCollider2D collider;
    public Animator animator;

        public bool platePressed1;
    public bool platePressed2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        Debug.Log("Opened");
        collider.enabled = false;
        animator.SetBool("isOpened", true);
    }

    public void Close()
    {
        animator.SetBool("isOpened", false);
        Debug.Log("Closeed");
        collider.enabled = true;

    }
}
