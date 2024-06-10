using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light lightSource;

    public void TurnOn()
    {
        lightSource.enabled = true;
    }

    public void TurnOff()
    {
        lightSource.enabled = false;
    }

    public bool IsOn()
    {
        return lightSource.enabled;
    }
}
