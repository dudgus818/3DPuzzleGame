using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkEffect : MonoBehaviour
{
    public GameObject blinkPanel; // 화면 깜빡임 효과용 패널
    public Button actionButton; // 생성될 버튼
    public float blinkDuration = 0.5f; // 깜빡이는 시간

    private void Start()
    {
        blinkPanel.SetActive(false);
        actionButton.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Blink());
        }
    }

    IEnumerator Blink()
    {
        blinkPanel.SetActive(true);
        yield return new WaitForSeconds(blinkDuration);
        blinkPanel.SetActive(false);
        actionButton.gameObject.SetActive(true);
    }
}
