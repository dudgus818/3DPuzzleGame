using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator doorAnimator; // ���� �ִϸ�����
    // ���� ���� �޼���
    public void OpenDoor()
    {
       doorAnimator.SetTrigger("Open");
    }
}
