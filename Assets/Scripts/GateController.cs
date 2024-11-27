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
    public SpriteRenderer lamp;
    public Sprite lampOn;
    public Sprite lampOff;

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
        lamp.sprite = lampOn;
        Debug.Log("Gate Opened for " + openDuration);
        isOpen = true;
        collider.enabled = false;
        animator.SetBool("GateOpen", true);
    }

    public void CloseGate()
    {
        lamp.sprite = lampOff;
        Debug.Log("Gate Close after " + openDuration);
        isOpen = false;
        collider.enabled = true;
        animator.SetBool("GateOpen", false);
    }
}
