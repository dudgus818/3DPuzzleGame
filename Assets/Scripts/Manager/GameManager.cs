using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerController playerController;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerController = FindObjectOfType<PlayerController>();
        playerController.ToggleCursor(false);
        Time.timeScale = 0f;
    }
}
