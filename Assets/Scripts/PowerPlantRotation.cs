using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPlantRotation : MonoBehaviour
{
    [SerializeField] private float RotationSpeed;
    [SerializeField] private float pitch = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pitch += RotationSpeed;
        if (pitch >= 360)
            pitch = 0;
        transform.localRotation = Quaternion.Euler(0,0,pitch);
    }
}
