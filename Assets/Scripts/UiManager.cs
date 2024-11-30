using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SoundManager.Instance.Play(Sounds.LevelStart);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SoundManager.Instance.Play(Sounds.LevelStart);
    }

    public void Quit()
    {
        Application.Quit();
        SoundManager.Instance.Play(Sounds.ButtonClick);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        SoundManager.Instance.Play(Sounds.ButtonClick);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        SoundManager.Instance.Play(Sounds.ButtonClick);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        SoundManager.Instance.Play(Sounds.ButtonClick);
    }

    public void Restart()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        SoundManager.Instance.Play(Sounds.LevelStart);
    }

    public void NextLevel()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SoundManager.Instance.Play(Sounds.LevelStart);
    }

    public void ButtonClick()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
    }



}
