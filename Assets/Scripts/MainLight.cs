using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MainLight : MonoBehaviour
{
    
    [SerializeField] private Material skyboxMaterial;
    private float angle = 0;
    [SerializeField] private float speed;

    private void Update()
    {
        angle += Time.deltaTime * speed;
        transform.localRotation = Quaternion.Euler(angle, 0, 0);
        skyboxMaterial.SetVector("_MainLightDirection", transform.forward);
    }
}
