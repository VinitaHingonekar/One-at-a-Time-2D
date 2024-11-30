using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyController : MonoBehaviour
{
    public static int keysCollected;
    public Animator[] doorAnimators;
    public Image[] keysImage;

    void Start()
    {
        keysCollected = 0;
    }

    public void KeyCollected()
    {
        
        keysCollected++;
        if(keysCollected == 1)
        {
            doorAnimators[0].SetTrigger("DoorOpen");
            Color color = keysImage[0].color;
            color.a = 1f;
            keysImage[0].color = color;
        }
        else
        {
            doorAnimators[1].SetTrigger("DoorOpen");
            Color color = keysImage[1].color;
            color.a = 1f;
            keysImage[1].color = color;
        }

        Debug.Log("Keys collected = " + keysCollected);
    }
}
