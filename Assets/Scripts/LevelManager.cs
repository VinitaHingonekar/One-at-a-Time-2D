using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public KeyController keyController;
    public DoorController door1;
    public DoorController door2;

    public GameObject levelCompletePanel;
    public GameObject gamePanel;

    private int levels = 3;

    void Update()
    {
        if(KeyController.keysCollected == 2)
        {
            if(door1.isPlayerAtDoor && door2.isPlayerAtDoor)
            {
                if(SceneManager.GetActiveScene().buildIndex == levels)
                    StartCoroutine("GameComplete");
                else
                    StartCoroutine("LevelComplete");
            }
        }
    }

    private IEnumerator LevelComplete()
    {
        // SoundManager.Instance.Play(Sounds.LevelFinish);
        yield return new WaitForSeconds(0.2f);
        levelCompletePanel.SetActive(true);
        gamePanel.SetActive(false);
    }

    private IEnumerator GameComplete()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
