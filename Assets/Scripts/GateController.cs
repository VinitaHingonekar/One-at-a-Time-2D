using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GateController : MonoBehaviour
{
    public float openDuration;
    public bool isOpen;

    public BoxCollider2D collider;
    public Animator animator;

    // Lamp
    public Animator lampAnimator;

    private IEnumerator GateCoroutine()
    {
        OpenGate();

        yield return new WaitForSeconds(openDuration);

        CloseGate();
    }

    public void OpenGate()
    {
        lampAnimator.SetBool("LeverOn", true);
        Debug.Log("Gate Opened for " + openDuration);
        isOpen = true;
        collider.enabled = false;
        animator.SetBool("GateOpen", true);
    }

    public void CloseGate()
    {
        lampAnimator.SetBool("LeverOn", false);
        Debug.Log("Gate Close after " + openDuration);
        isOpen = false;
        collider.enabled = true;
        animator.SetBool("GateOpen", false);
    }
}
