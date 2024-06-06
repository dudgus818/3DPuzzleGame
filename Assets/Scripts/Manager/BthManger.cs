using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BthManger : MonoBehaviour
{
    public GameObject StatPanel;
    public GameObject GameStopPanel;

    private PlayerController playerController;

    public void StartPanel()
    {
        AudioManager audioManager = FindAnyObjectByType<AudioManager>();
        playerController = FindObjectOfType<PlayerController>();
        playerController.ToggleCursor(true);
        StatPanel.SetActive(false);
        Time.timeScale = 1f;

        if (audioManager != null)
        {
            audioManager.PlayClickSound();
        }
    }

    public void SettingOn()
    {
        AudioManager audioManager = FindAnyObjectByType<AudioManager>();
        if (audioManager != null)
        {
            audioManager.PlayClickSound();
        }
    }

    public void ExitGame()
    {
        AudioManager audioManager = FindAnyObjectByType<AudioManager>();
        if (audioManager != null)
        {
            audioManager.PlayClickSound();
        }
    }
}
