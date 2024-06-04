using UnityEngine;
using System;

public class PlayerCondition : MonoBehaviour
{
    public Condition condition;
    public UiCondition uiCondition;

    private PlayerController playerController;

    [Header ("Sprint")]
    public float staminaDrainRate = 10f;  // 매초마다 감소할 스태미나 양
    public float staminaRegenRate = 5f;
    public float staminaRegenDelay = 5f;
    private float staminaRegenTimer;
    private float staminaDrainTimer; // 매초 스태미나 감소를 위한 타이머

    Condition sprintStamina { get { return uiCondition.sprintStamina; }}

    void Start()
    {
        condition = CharacterManager.Instance.GetComponent<Condition>();
        playerController = CharacterManager.Instance.Player.GetComponent<PlayerController>();
    }

    void Update()
    {
        HandleStamina();
        if(!playerController.isSprinting)
        {
            AddSprintStamina();
        }
    }

    public void HandleStamina()
    {
        if (playerController.isSprinting)
        {
            SubtractSprintStamina();

            if (sprintStamina.curValue <= 0)
            {
                sprintStamina.curValue = 0;
                playerController.isSprinting = false;  // 스태미나가 바닥나면 스프린트 중지
            }
        }
    }

    public void AddSprintStamina()
    {
        sprintStamina.Add(sprintStamina.addValue * Time.deltaTime);
    }

    public void SubtractSprintStamina()
    {
        sprintStamina.Subtract(sprintStamina.subtractValue * Time.deltaTime);
    }
}
