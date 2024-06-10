using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    public float checkRate = 0.05f;
    private float lastCheckTime;
    public float maxCheckDistance;

    [Header("InteractableObject")]
    public InteractableObject currentInteractable;

    private PlayerController playerController;
    private Camera camera;

    void Start()
    {
        camera = Camera.main;
        playerController = CharacterManager.Instance.Player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastCheckTime > checkRate)
        {
            lastCheckTime = Time.time;

            Ray ray = camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            Debug.DrawRay(ray.origin, ray.direction * maxCheckDistance, UnityEngine.Color.red, checkRate);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, maxCheckDistance))
            {
                if (hit.collider.CompareTag("InteractableObject"))
                {
                    if (hit.collider.gameObject != currentInteractable)
                    {
                        currentInteractable = hit.collider.GetComponent<InteractableObject>();
                    }
                }
            }
            else
            {
                currentInteractable = null;
                //promptText.gameObject.SetActive(false);
            }
        }
    }

    //    private void SetPromptText()
    //{
    //    promptText.gameObject.SetActive(true);
    //    promptText.text = curInteractable.GetInteractPrompt();
    //}

    public void OnInteractInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started && currentInteractable != null)
        {
            currentInteractable.Interact();
            currentInteractable = null;
            playerController.ToggleCursor();
            //promptText.gameObject.SetActive(false);

            AudioManager audioManager = FindAnyObjectByType<AudioManager>();
            if (audioManager != null)
            {
                audioManager.PlayInventorySound();
            }
        }
    }
}
