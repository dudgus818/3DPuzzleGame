using UnityEngine;
using TMPro;

public class DoorLock1 : MonoBehaviour
{
    public TMP_Text resultText;  // 결과를 표시할 텍스트 필드
    private string input = "";  // 사용자 입력을 저장할 문자열
    private string correctPassword = "CANIS"; // 설정된 테스트 비밀번호 (영어로 변경)
    public DoorController doorController;
    public InteractableObject interactableObject;

    private PlayerController controller;

    // 알파벳 버튼이 클릭될 때 호출되는 메서드
    public void OnLetterButtonClick(string letter)
    {
        if (input.Length < 5)
        {
            input += letter;
            resultText.text = input;
        }
    }

    // 'C' 버튼이 클릭될 때 호출되는 메서드 (초기화)
    public void OnClearButtonClick()
    {
        input = "";
        resultText.text = "0";
    }

    // 비밀번호 확인 메서드
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
            input = ""; // 입력 초기화
        }
    }
}