using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public BoxCollider2D collider;
    public Animator animator;
    public Animator keyAnimator;
    public KeyController keyController;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            Debug.Log("Chest Opened");
            animator.SetTrigger("ChestOpen");
            keyAnimator.SetTrigger("ChestOpen");
            keyController.KeyCollected();
            collider.enabled = false;
        }    
    }
}
