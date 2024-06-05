using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject interactionUI;
    public PlayerController playerController;

    private void OnTriggerEnter(Collider other)
    {
        SetInteractionUIState(other, true);
    }

    private void OnTriggerExit(Collider other)
    {
        SetInteractionUIState(other, false);
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
}
