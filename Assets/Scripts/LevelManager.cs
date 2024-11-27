using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public KeyController keyController;
    public DoorController door1;
    public DoorController door2;

    public GameObject levelCompletePanel;
    public GameObject gamePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(KeyController.keysCollected == 2)
        {
            if(door1.isPlayerAtDoor && door2.isPlayerAtDoor)
            {
                Debug.Log("level completed");
                StartCoroutine("LevelComplete");
            }
        }
    }

    private IEnumerator LevelComplete()
    {
        yield return new WaitForSeconds(1f);
        levelCompletePanel.SetActive(true);
        gamePanel.SetActive(false);
    }
}
