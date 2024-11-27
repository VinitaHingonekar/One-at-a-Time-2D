using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    public float openDuration;
    public bool isOpen;

    public BoxCollider2D collider;
    public Animator animator;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private IEnumerator GateCoroutine()
    {
        OpenGate();

        yield return new WaitForSeconds(openDuration);

        CloseGate();
    }

    public void OpenGate()
    {
        Debug.Log("Gate Opened for " + openDuration);
        isOpen = true;
        collider.enabled = false;
        animator.SetBool("GateOpen", true);
    }

    public void CloseGate()
    {
        Debug.Log("Gate Close after " + openDuration);
        isOpen = false;
        collider.enabled = true;
        animator.SetBool("GateOpen", false);
    }
}
