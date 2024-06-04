using UnityEngine;
using System;

public class PlayerCondition : MonoBehaviour
{
    public Condition condition;
    public UiCondition uiCondition;

    private PlayerController playerController;

    [Header ("Sprint")]
    public float staminaDrainRate = 10f;  // ���ʸ��� ������ ���¹̳� ��
    public float staminaRegenRate = 5f;
    public float staminaRegenDelay = 5f;
    private float staminaRegenTimer;
    private float staminaDrainTimer; // ���� ���¹̳� ���Ҹ� ���� Ÿ�̸�

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
                playerController.isSprinting = false;  // ���¹̳��� �ٴڳ��� ������Ʈ ����
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
