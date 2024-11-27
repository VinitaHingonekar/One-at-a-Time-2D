using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public GateController gateController;
    public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(playerInRange)
        // {
            CheckPlayerInRange();
        // }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            playerInRange = true;
            Debug.Log("player in range");
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        playerInRange = false;
        Debug.Log("player not in range");
    }

    private void CheckPlayerInRange()
    {
        if(!gateController.isOpen && Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            // Debug.Log("Lamp Triggered");
            // gateController.OpenGate();
            gateController.StartCoroutine("GateCoroutine");
        }
    }

    // private IEnumerator GateCoroutine()
    // {
    //     gateController.OpenGate();
    // }
}
