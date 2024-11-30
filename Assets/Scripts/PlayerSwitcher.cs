using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSwitcher : MonoBehaviour
{
    public GameObject[] characters;
    public Image[] characterSprites;

    void Start()
    {
        SwitchCharacter(0);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchCharacter(0);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchCharacter(1);
        }
    }

    private void SwitchCharacter(int index)
    {
        for(int i = 0; i < characters.Length; i++)
        {
            Color color = characterSprites[i].color;

            PlayerController controller = characters[i].GetComponent<PlayerController>();
            if(controller != null)
            {
                controller.isActive = (i == index);
            }
            if(controller.isActive)
            {
                color.a = 1f;
                characterSprites[i].color = color;
            }
            else
            {
                color.a = 0.5f;
                characterSprites[i].color = color;
            }
        }
    }
}