using UnityEngine;
using TMPro;

public class DoorLock1 : MonoBehaviour
{
    public TMP_Text resultText;  // ����� ǥ���� �ؽ�Ʈ �ʵ�
    private string input = "";  // ����� �Է��� ������ ���ڿ�
    private string correctPassword = "CANIS"; // ������ �׽�Ʈ ��й�ȣ (����� ����)
    public DoorController doorController;
    public InteractableObject interactableObject;

    private PlayerController controller;

    // ���ĺ� ��ư�� Ŭ���� �� ȣ��Ǵ� �޼���
    public void OnLetterButtonClick(string letter)
    {
        if (input.Length < 5)
        {
            input += letter;
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
            resultText.text = "Access Granted";
            doorController.isOpen = true;
        }
        else
        {
            resultText.text = "Access Denied";
            input = ""; // �Է� �ʱ�ȭ
        }
    }
}