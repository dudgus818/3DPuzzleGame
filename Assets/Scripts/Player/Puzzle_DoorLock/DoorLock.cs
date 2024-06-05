using UnityEngine;
using TMPro;

public class DoorLock : MonoBehaviour
{
    public TMP_Text resultText;  // ����� ǥ���� �ؽ�Ʈ �ʵ�
    private string input = "";  // ����� �Է��� ������ ���ڿ�

    // ���� ��ư�� Ŭ���� �� ȣ��Ǵ� �޼���
    public void OnNumberButtonClick(string number)
    {
        input += number;
        resultText.text = input;
    }

    // 'C' ��ư�� Ŭ���� �� ȣ��Ǵ� �޼��� (�ʱ�ȭ)
    public void OnClearButtonClick()
    {
        input = "";
        resultText.text = "0";
    }
}
