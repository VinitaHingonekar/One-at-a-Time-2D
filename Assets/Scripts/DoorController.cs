using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isPlayerAtDoor = false;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        isPlayerAtDoor = true;
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        isPlayerAtDoor = false;
    }
}
