using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light[] lights; // ������
    public int[] correctOrder; // �ùٸ� ����
    private int currentStep = 0; // ���� �ܰ�

    public void SwitchPressed(int switchId)
    {
        // currentStep�� correctOrder�� ������ ����� �ʵ��� Ȯ���մϴ�.
        if (currentStep < correctOrder.Length && correctOrder[currentStep] == switchId)
        {
            currentStep++;
            UpdateLights(true);

            // ������ ��� ���� ��� currentStep�� �����մϴ�.
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