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
        // ��ȣ�ۿ� �ڵ� ����
        Debug.Log("��ȣ�ۿ�� ������Ʈ: " + gameObject.name);
        interactionUI.SetActive(false);
    }
}
