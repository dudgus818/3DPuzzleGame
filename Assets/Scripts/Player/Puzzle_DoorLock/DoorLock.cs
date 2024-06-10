using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class DoorLock : MonoBehaviour
{
    public TMP_Text resultText;  // 결과를 표시할 텍스트 필드
    private string input = "";  // 사용자 입력을 저장할 문자열
    private string correctPassword = "1234"; // 설정된 테스트 비밀번호
    public DoorController doorController;
    public InteractableObject interactableObject;

    private PlayerController playerController;

    private void Start()
    {
        playerController = CharacterManager.Instance.Player.GetComponent<PlayerController>();
    }

    // 숫자 버튼이 클릭될 때 호출되는 메서드
    public void OnNumberButtonClick(string number)
    {
        if (input.Length < 4)
        {
            input += number;
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
            resultText.text = "Access";
            doorController.isOpen = true;
            playerController.ToggleCursor();
        }
        else
        {
            resultText.text = "ERROR";
            input = ""; // 입력 초기화
        }
    }
}
