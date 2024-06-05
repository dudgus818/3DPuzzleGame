using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator doorAnimator; // 문의 애니메이터
    // 문을 여는 메서드
    public void OpenDoor()
    {
       doorAnimator.SetTrigger("Open");
    }
}
