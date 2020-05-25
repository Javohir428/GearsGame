using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOff : MonoBehaviour
{
    public void LightOn()
    {
        RenderSettings.ambientIntensity = 1;
        RenderSettings.reflectionIntensity = 1;
    }
}
