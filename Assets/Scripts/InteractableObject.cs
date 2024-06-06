using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject interactionUI;
    public PlayerController playerController;

    private bool isLocked = false; // ��ȣ�ۿ� ��� ���¸� ��Ÿ���� �÷���

    private void OnTriggerEnter(Collider other)
    {
        if (!isLocked)
        {
            SetInteractionUIState(other, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!isLocked)
        {
            SetInteractionUIState(other, false);
        }
    }

    private void SetInteractionUIState(Collider other, bool state)
    {
        if (other.CompareTag("Player"))
        {
            if (playerController != null)
            {
                playerController.ToggleCursor(state);
            }

            if (interactionUI != null)
            {
                interactionUI.SetActive(state);
            }
        }
    }

    public void Interact()
    {
        // ��ȣ�ۿ� �ڵ� ����
        Debug.Log("��ȣ�ۿ�� ������Ʈ: " + gameObject.name);
        interactionUI.SetActive(false);
    }

    public void SetLocked(bool locked)
    {
        isLocked = locked;

        // ��� ���·� �����Ǹ� ��ȣ�ۿ� UI�� ��Ȱ��ȭ
        if (locked && interactionUI != null)
        {
            interactionUI.SetActive(false);
            playerController.ToggleCursor(false);
        }
    }
}
