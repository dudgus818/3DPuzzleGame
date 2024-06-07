using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerController playerController;

    void Start()
    {
        Invoke("GameStart", 0.01f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GameStart()
    {
        playerController = FindObjectOfType<PlayerController>();
        playerController.ToggleCursor();
        Time.timeScale = 0f;
    }
}
