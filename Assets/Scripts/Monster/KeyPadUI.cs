using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPadUI : MonoBehaviour
{
    public GameObject keypadUI;
    public Text displayText;
    public string correctCode = "Leave me";
    public GameObject targetObject; // 키패드 입력 후 사라질 오브젝트
    private string inputCode = "";
    private float inputTimeLimit = 10.0f;
    private float timer;
    private bool isInputActive = false;

    private void Start()
    {
        keypadUI.SetActive(false);
    }

    private void Update()
    {
        if (isInputActive)
        {
            timer += Time.deltaTime;
            if (timer > inputTimeLimit)
            {
                GameOver();
            }
        }
    }

    public void OnButtonClick(string number)
    {
        if (inputCode.Length < correctCode.Length)
        {
            inputCode += number;
            UpdateDisplay();
        }
    }

    public void OnEnterClick()
    {
        if (inputCode == correctCode)
        {
            Destroy(targetObject);
            keypadUI.SetActive(false);
            isInputActive = false;
        }
        else
        {
            GameOver();
        }
    }

    public void ActivateKeypad()
    {
        keypadUI.SetActive(true);
        inputCode = "";
        UpdateDisplay();
        timer = 0f;
        isInputActive = true;
    }

    private void UpdateDisplay()
    {
        displayText.text = inputCode;
    }

    private void GameOver()
    {
        Debug.Log("게임 오버");
        // 게임 오버 UI 또는 처리 추가
        keypadUI.SetActive(false);
        isInputActive = false;
    }
}
