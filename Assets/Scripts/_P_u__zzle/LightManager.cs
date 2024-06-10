using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LightManager : MonoBehaviour
{
    public int switchId; // 버튼 ID
    public LightController lightController; // 전구 컨트롤러
    public void OnButtonPressed()
    {
        lightController.SwitchPressed(switchId);
    }
}
