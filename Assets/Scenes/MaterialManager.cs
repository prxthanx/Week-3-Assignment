using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MaterialManager : MonoBehaviour
{
    public GameObject targetObject;  // Assign the object you want to apply the material to
    public Texture texture;          // Assign a texture in the Inspector

    void Start()
    {
        // Create a new material with Unity’s Standard shader
        Material newMaterial = new Material(Shader.Find("Standard"));
        newMaterial.color = Color.green;      // Set base color
        newMaterial.mainTexture = texture;    // Set texture

        // Apply the material to the target object
        targetObject.GetComponent<Renderer>().material = newMaterial;
    }
}
