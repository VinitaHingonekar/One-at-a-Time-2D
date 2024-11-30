using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public GateController gateController;
    public bool playerInRange;

    void Update()
    {
        CheckPlayerInRange();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        playerInRange = false;
    }

    private void CheckPlayerInRange()
    {
        if(!gateController.isOpen && Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            SoundManager.Instance.Play(Sounds.LeverPull);
            gateController.StartCoroutine("GateCoroutine");
        }
    }
}
