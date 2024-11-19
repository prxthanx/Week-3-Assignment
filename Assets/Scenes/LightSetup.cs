using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LightSetup : MonoBehaviour
{
    void Start()
    {
        // Create a directional light
        GameObject lightGameObject = new GameObject("Directional Light");
        Light lightComp = lightGameObject.AddComponent<Light>();
        lightComp.type = LightType.Directional;
        lightComp.color = Color.white;
        lightComp.intensity = 1.0f;

        // Set light rotation
        lightGameObject.transform.rotation = Quaternion.Euler(50, -30, 0);
    }
}
