using UnityEngine;
using TMPro;

public class DoorLock : MonoBehaviour
{
    public TMP_Text resultText;  // ����� ǥ���� �ؽ�Ʈ �ʵ�
    private string input = "";  // ����� �Է��� ������ ���ڿ�
    private string correctPassword = "1234"; // ������ �׽�Ʈ ��й�ȣ
    public DoorController doorController;
    public InteractableObject interactableObject;

    private PlayerController controller;

    // ���� ��ư�� Ŭ���� �� ȣ��Ǵ� �޼���
    public void OnNumberButtonClick(string number)
    {
        if (input.Length < 4)
        {
            input += number;
            resultText.text = input;
        }
    }

    // 'C' ��ư�� Ŭ���� �� ȣ��Ǵ� �޼��� (�ʱ�ȭ)
    public void OnClearButtonClick()
    {
        input = "";
        resultText.text = "0";
    }

    // ��й�ȣ Ȯ�� �޼���
    public void OnCheckPassword()
    {
        if (input == correctPassword)
        {
            resultText.text = "Access";
            doorController.isOpen = true;
            interactableObject.SetLocked(true);
        }
        else
        {
            resultText.text = "ERROR";
            input = ""; // �Է� �ʱ�ȭ
        }
    }
}
