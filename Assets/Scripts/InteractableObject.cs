using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject interactionUI;
    public GameObject interactPuzzleUI;

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
        else if (interactPuzzleUI != null)
        {
            interactPuzzleUI.SetActive(false);
        }
    }

    private void SetInteractionUIState(Collider other, bool state)
    {
        if (other.CompareTag("Player"))
        {
            if (interactionUI != null)
            {
                interactionUI.SetActive(state);
            }

        }
    }

    public void Interact()
    {
        if(isPuzzleOpen())
        {
            interactPuzzleUI.SetActive(false);
        }
        else
        {
            Debug.Log("MASIC");
            interactPuzzleUI.SetActive(true);
        }
    }

    public bool isPuzzleOpen()
    {
        return interactPuzzleUI.activeInHierarchy;
    }

    public void SetLocked(bool locked)
    {
        isLocked = locked;

        if (locked && interactionUI != null)
        {
            interactionUI.SetActive(false);
        }
    }
}
