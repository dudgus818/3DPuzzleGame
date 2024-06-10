using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LightManager : MonoBehaviour
{
    public LightController[] lights;
    public Button[] buttons;
    public TMP_Text resultText;
    public int[] correctSequence = { 0, 1, 2 }; // 버튼을 눌러야 하는 올바른 순서
    private int currentStep = 0;

    private void Start()
    {
        ResetLights();
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => OnButtonClick(button));
        }
        resultText.text = "";
    }

    private void ResetLights()
    {
        foreach (LightController light in lights)
        {
            light.TurnOff();
        }
        currentStep = 0;
    }

    public void OnButtonClick(Button button)
    {
        int buttonIndex = System.Array.IndexOf(buttons, button);
        if (buttonIndex == correctSequence[currentStep])
        {
            lights[buttonIndex].TurnOn();
            currentStep++;
            if (currentStep >= correctSequence.Length)
            {
                resultText.text = "Succes!! PassWord = 1234";
            }
        }
        else
        {
            RandomizeLights();
            currentStep = 0;
            //resultText.text = "잘못된 순서입니다. 랜덤으로 전구가 변경되었습니다.";
        }
    }

    private void RandomizeLights()
    {
        foreach (LightController light in lights)
        {
            if (Random.value > 0.5f)
            {
                light.TurnOn();
            }
            else
            {
                light.TurnOff();
            }
        }
    }
}
