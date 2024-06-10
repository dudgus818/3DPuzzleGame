using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light[] lights; // 전구들
    public int[] correctOrder; // 올바른 순서
    private int currentStep = 0; // 현재 단계

    public void SwitchPressed(int switchId)
    {
        // currentStep이 correctOrder의 범위를 벗어나지 않도록 확인합니다.
        if (currentStep < correctOrder.Length && correctOrder[currentStep] == switchId)
        {
            currentStep++;
            UpdateLights(true);

            // 정답을 모두 맞춘 경우 currentStep을 리셋합니다.
            if (currentStep == correctOrder.Length)
            {
                Debug.Log("Puzzle Solved!");
                currentStep = 0;
            }
        }
        else
        {
            currentStep = 0;
            UpdateLights(false);
        }
    }

    private void UpdateLights(bool correct)
    {
        for (int i = 0; i < lights.Length; i++)
        {
            if (correct)
            {
                if (i < currentStep)
                {
                    lights[i].enabled = true;
                }
                else
                {
                    lights[i].enabled = false;
                }
            }
            else
            {
                lights[i].enabled = false;
            }
        }
    }
}