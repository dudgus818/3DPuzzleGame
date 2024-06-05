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
        // 상호작용 코드 구현
        Debug.Log("상호작용된 오브젝트: " + gameObject.name);
        interactionUI.SetActive(false);
    }
}
