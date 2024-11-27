using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isPlayerAtDoor = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        isPlayerAtDoor = true;
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        isPlayerAtDoor = false;
    }
}
