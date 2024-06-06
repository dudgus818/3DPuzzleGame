using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject interactionUI;
    public GameObject playerUI;
    public PlayerController playerController;

    private bool isLocked = false; // 상호작용 잠금 상태를 나타내는 플래그

    private void OnTriggerEnter(Collider other)
    {
        if (!isLocked)
        {
            SetInteractionUIState(other, true);
            playerUI.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!isLocked)
        {
            SetInteractionUIState(other, false);
            playerUI.SetActive(true);
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
        // 상호작용 코드 구현
        Debug.Log("상호작용된 오브젝트: " + gameObject.name);
        interactionUI.SetActive(false);
    }

    public void SetLocked(bool locked)
    {
        isLocked = locked;

        // 잠금 상태로 설정되면 상호작용 UI를 비활성화
        if (locked && interactionUI != null)
        {
            interactionUI.SetActive(false);
            playerController.ToggleCursor(false);
        }
    }
}
