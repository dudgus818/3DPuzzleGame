using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject interactionUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionUI.SetActive(false);
        }
    }

    public void Interact()
    {
        // 상호작용 코드 구현
        Debug.Log("상호작용된 오브젝트: " + gameObject.name);
        interactionUI.SetActive(false);
    }
}
